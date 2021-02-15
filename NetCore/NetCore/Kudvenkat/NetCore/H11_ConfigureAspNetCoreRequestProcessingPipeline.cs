using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Kudvenkat.NetCore
{
    public class H11_ConfigureAspNetCoreRequestProcessingPipeline
    {
        /*
            The configure method which is present in the Startup class that sets up the request processing pipeline for our ASP.NET Core application as part of the
            application start up. At the moment we have two Middlewares in the pipeline UseDeveloperExceptionPage() and Run(). As the name implies,
            UseDeveloperExceptionPage() Middleware response with an exception if there is exception and if the environment is development. The second Middleware
            which is registered using the Run method can only write a message to the Response object.
            
            At the moment, Run() Middleware that response to every request and the message we are writing to the response object, does not matter what is the request
            path all requests will be handled by this one piece of Middleware. The response we would be getting is a plain text not html, we can also confirm this
            by inspecting the page source. You will notice that page source will not have any html it would only consists of plain text. Currently, it doesn't matter
            what the request path is for example if we type: http://localhost:15410/abc or any other page we would see the same old text.
            
            So as it stands right now, Run is the Middleware that responds to every request even if we have a physical HTML file and if we navigate to that file in
            the url the file will not be served. By default, if we want to be able to serve static files like HTML files, CSS files, image files there needs to be a
            special folder named "wwwroot". To this folder, lets add a new HTML file. Now when you run your application and change the address bar of the browser
            to include the html file as well, we won't be able to see file of HTML file our application will still show us the same output. Point here is, every
            request that comes to our application this is the Middleware that responds to that request. As it stands right now, our application request processing
            pipeline does not even have the capability to serve static files like HTML files, images, CSS, JavaScript files etc.
            
            Understanding Run Method
            Run method is implemented as an extension method of IApplicationBuilder interface. That is the reason we are able to invoke this Run method on the
            instance of IApplicationBuilder app. The parameter that we are passing to the Run method is a RequestDelegate. If we go the definition of the Run method
            and we will see that the parameter is a RequestDelegeate.
            
            A RequestDelegate is a delegate that takes HTTPContext object as a parameter. If we further go the definition of a RequestDelegate we will see that it
            expects HTTPContext object as a parameter. And this is the reason we were able to pass context object as a parameter to the anonymous method. It is true
            that this HTTPContext object (the Middleware we are registering) gains access to both the incoming HTTP request and the outgoing HTTP response.
            
            Notice, on the HTTPContext object that is passed as a parameter we have a response property which provides us access to the response object. Similarly,
            the context object also has the request property which provides us access to the request. At the moment, we are passing our Middleware inline as an
            anonymous method using a lambda expression. We have defined our Middleware inline using an anonymous method, if we want we can also define it in a
            separate reusable class.
            
            If we use two Run methods with different logic and execute the code, we will notice that only first Run method output is rendered on the screen. Why
            is that? Because the Middleware we register becomes a Termimal piece of Middleware.
            
            A Terminal Middleware is a Middleware that does not call the next Middleware in the pipeline. So the first Middleware is a Terminal, so it handles the
            request, produces the response and the pipeline reverses itself from here. The below Middleware in the pipeline never gets the opportunity to execute
            that is the reason we don't see the second message on the screen.
            
            If you want your Middleware to be able to call the next Middleware in the pipeline then register your Middleware using Use() method. Use() method takes
            two parameters, in addition to HTTPContext object it takes next as a second parameter. The return type of this parameter is Func i.e. it's a generic
            delegate and in this case this parameter represents the next piece of Middleware in the pipeline. So this delegate is going to automatically call the
            next piece of Middleware in the pipeline, you just have to do the below code:
            await next();
            
            Now we can see messages from both of the Middlewares components. Let's take this example to the next level. In addition to the IApplicationBuilder and
            IHostingEnvironment services, I am going to inject a 3rd service - ILogger service. We want a Logger for our Startup class.
            
            We already know the execution of the ASP.NET Core application, starts with the Main() method. The Main() method calls CreateDefaultBuilder() and
            CreateDefaultBuilder() method sets up the default WebHost for our ASP.NET Core project. As part of setting up the WebHost, this method does several things.
            If we take a look at the WebHost class on the GitHub page, and if we search for CreateDefaultBuilder() method we will find that it does several things,
            it sets up Kestrel as a web server in UseKestrel() method, it configures application configurations in ConfigureAppConfiguration and it also configures
            logging in ConfigureLogging. We have a logger for Console, Debug and EventSource.
            
            In the Startup Class, we are going to change the implementation of our Middleware component to incorporate the logger and log couple of messages. After
            doing the required changes and running the application, take a look at the Output window of the Visual Studio (make sure to select the Debug option from
            the dropdown). Look at the order of the messages printed on the Output window. Below is the output:
            
            NetCore.Startup:Information: MW1: Incoming Request
            NetCore.Startup:Information: MW2: Incoming Request
            NetCore.Startup:Information: MW3: Request Handled and Response Produced
            NetCore.Startup:Information: MW2: Outgoing Response
            NetCore.Startup:Information: MW1: Outgoing Response
            
            Let's relate these messages to the diagram below:
            
                                        +----------------+       +----------------+       +----------------+
            +-------------+             |  Middleware 1  |       |  Middleware 2  |       |  Middleware 3  |
            |   Request   |------------>|                |       |                |       |                |
            +-------------+             |  // logic      |       |                |       |                |
                                        |  next();-------------->|  // logic      |       |                |
                                        |                |       |  next();-------------->|  // logic      |
                                        |                |       |                |       |  // more logic |
                                        |                |       |                |       |       |        |
                                        |                |       |  // more logic |<--------------+        |
                                        |                |       |      |         |       |                |
                                        |  // more logic |<-------------+         |       |                |
            +-------------+             |      |         |       |                |       |                |
            |   Response  |<-------------------+         |       |                |       |                |
            +-------------+             |                |       |                |       |                |
                                        +----------------+       +----------------+       +----------------+
            
            We have three Middleware components in the pipeline and the request first arrives at Middleware1 component, Middleware1 executes some logic and calls the
            next Middleware by invoking the next() delegate. Then the next Middleware, Middleware2 in the pipeline is called. Middleware2 also has some logic before
            it invokes the next Middleware in the pipeline. Finally, the Middleware2 calls the third Middleware component and this is the component that handles the
            request and produces the response. At this time, the pipeline reverses itself so the response is passed from Middleware3 to Middleware2 and after that
            the response is passed from Middleware2 to Middleware1.
            
            Important:
            - Everything that happens before the next() method is invoked in each of the Middleware components, happens as the REQUEST travels from Middleware
              to Middleware through the pipeline and this is represented by the incoming arrow.
            - When a Middleware handles the request and produces response, the request processing pipeline starts to reverse.
            - Everything that happens after the next() method is invoked in each of the Middleware components, happens as the RESPONSE travels from Middleware to
              Middleware through the pipeline and this is represented by the outgoing arrow.
        */
    }
}
