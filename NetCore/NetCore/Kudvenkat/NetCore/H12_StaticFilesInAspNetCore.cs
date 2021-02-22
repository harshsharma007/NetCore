using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Kudvenkat.NetCore
{
    public class H12_StaticFilesInAspNetCore
    {
        /*
            By default an ASP.NET Core application will not be able to serve static files to be able to serve static files our application should meet two requirements:
            1. All the static files must be present in the wwwroot folder. This folder is called content root folder and it must be directly inside the root project
               folder. Add an image to the wwwroot folder, to be able to access the image from the browser we first specify the name of the server. In our case, we
               are running our application on our local machine.
               eg. http://localhost:15410/images/JohnWick.jpg
               
               If you hit the above URL, you won't be able to see the image. We still see the response that is produced by the middleware that we have registered using
               Run() method. This is because right now, the request processing pipeline that we have for our application does not have the capability to serve static
               files.
            
            2. To serve static files, we have to register another piece of Middleware and that is UseStaticFiles() Middleware. This is the second requirement to serve
               the static files. After using UseStaticFiles() Middleware, when we now run the above URL we would be able to see the image file in the browser.
            
            We can even create folders inside the wwwroot folder like css, images, js etc. By default UseStaticFiles() Middleware will only serve static files that
            are present in the wwwroot folder. It's also possible to serve static files that are outside of wwwroot folder.
            
            Most web applications also have a default document and it is that default document that is displayed when we navigate to the root URL of our application
            for example when we navigate to http://localhost:15410 without any other URL segments, we want to serve the default document but at the moment we see the
            response produced by the Middleware that is registered using Run() method.
            
            To accomplish this, let's add a default page for our application. By default, the name of the default page for our application should be one of the
            following:
            - default.htm
            - default.html
            - index.htm
            - index.html
            
            Let's add a page with name, default.html. After adding the default file, if you load the default URL i.e. http://localhost:15410 you still won't be able
            to see the content of default.html page because to serve the content of default page we have to use another Middleware component with the name
            UseDefaultFiles().
            
            Important:
            The order in which UseStaticFiles() and UseDefaultFiles() Middlewares are registered is very important. UseDefaultFiles() must be registered before
            UseStaticFiles(). If we don't follow this order then we won't be able to see the default page output because the UseDefaultFiles() Middleware doesn't
            actually serve the default file it only changes the request path to point to the default document, in our case to point to default.html which will then
            be served by the next piece of Middleware i.e. UseStaticFiles(). The URL at address bar would be http://localhost:15410, it will not change to include
            the path of default page.
            
            What if we do not want the default.html to be our default document. Instead, we want foo.html or more commonly we may have home.html which we want to be
            our default document?
            
            To achieve that we have to customize the behavior of the UseDefaultFiles() Middleware. This Middleware method have got two more overloads. We're going to
            use the overloaded version which takes "DefaultFilesOptions" as a parameter.
            First, we have to create an instance of that class and after that we have to clear the DefaultFileNames using the Clear() method. Then we have to add
            foo.html as our default file name. For that we use, Add() method and then specify the name of our default document, which is foo.html. Finally, pass this
            defaultFilesOptions object to UseDefaultFiles() Middleware.
            
            There is another piece of Middleware called UseFileServer() Middleware, this UseFileServer() Middleware combines the functionality of UseDefaultFiles()
            and UseStaticFiles() and UseDirectoryBrowser() Middleware. As the name implies, UseDirectoryBrowser() Middleware enables directory browsing and allows
            the end user to see the list of files and folders in a specified directory.
            
            Now, we can replace UseDefaultFiles() and UseStaticFiles() Middlewares with UseFileServer() Middleware. And when you run the code, you'll notice that the
            output rendered on screen is of Default.html page. But even with FileServer we want to use foo.html as our default document, for that we need to customize
            UseFileServer() Middleware. And we can use overloaded version, where we can pass FileServerOptions object as the parameter, so instead of creating 
            DefaultFilesOptions object we create FileServerOptions object and specify foo.html as our default document and pass that object as a parameter to this
            Middleware.
            
            Important: After doing the changes, if you still see the previous response that might be the case because browser may have cached the output. If this is
            the case then you have to hard refresh the page and after doing that you would be able to see the desired output.
            
            Another important point to keep in mind is the pattern we use to add and customize these middleware components, in most cases we add Middleware components
            to our application request processing pipeline using extension method names that start with the word "Use", for example, UseDeveloperExceptionPage,
            UseFileServer, UseStaticFiles, UseDefaultFiles. And to customize these Middleware components we use the respective options object to customize developer
            exception page Middleware, we use DeveloperExceptionPageOptions for UseDeveloperExceptionPage. Notice the name is the same as that of the Middleware
            except that we have this "Options" word appended.
            
            Summary
            - By default an ASP.NET Core application will not serve static files.
            - The default directory for static files is wwwroot.
            - To serve static files UseStaticFiles() Middleware is required.
            - To serve a default file UseDefaultFiles() Middleware is required.
            
            The following are the default files
            - index.htm
            - index.html
            - default.htm
            - default.html
            
            - UseDefaultFiles() must be registered before UseStaticFiles()
            - UseFileServer combines the functionality of UseStaticFiles, UseDefaultFiles and UseDirectoryBrowser Middleware.
        */
    }
}
