﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Kudvenkat.NetCore
{
    public class H05_MainMethodInAspNetCore
    {
        /*
            In the previous version of .NET, usually a console application has a Program class and a Main method. But here we are building ASP.NET Core web application,
            so the obvious question that comes to our mind is:
            
            Why do we have a Main() method in ASP.NET Core Web application?
            
            - An important thing that needs to be kept in mind is an ASP.NET Core Web application initially starts as a Console application.
            
            - And, the Main method within the Program class is the entry point into this application.
            
            - When the Runtime executes the application, it looks for Main method. And this is where the execution of the ASP.NET Core application kicks off.
            
            - It is this Main method that configures ASP.NET Core and starts it. It is at this point it becomes an ASP.NET Core Web Application.
            
            - The Main method calls "CreateWebHostBuilder" passing it command line arguments (args) that are coming into the Main method.
            
            - The "CreateWebHostBuilder" method is just below Main method. This method returns an object that implements "IWebHostBuilder". On the object that this
              method returns we are calling "Build" method (in the Main method). The Build method builds the WebHost that hosts the ASP.NET Core application. On that
              WebHost we are again calling Run method. The Run method runs the web application and it starts listening for the incoming HTTP request.
            
            - The "CreateWebHostBuilder" method calls "CreateDefaultBuilder" method of the WebHost class. This is a static method and it is this method that creates
              the WebHost with certain preconfigured defaults. To create a WebHost "CreateDefaultBuilder" does several things.
            
            - Another important point to notice here is, as part of setting up the WebHost we are also configuring the "Startup" class using an extension method
              "UseStartup". By convention the "Startup" class in ASP.NET Core is named "Startup". If we go to the definition of this class that Startup class is present
              in a file named "Startup.cs". This is one of the files that is generated by the empty project template. Within this class we got two very important
              methods "ConfigureServices" and "Configure".
            
            - "ConfigureServices" as the name implies configures the services required for our application. And the "Configure" method, configures our application and
              request processing pipeline.
        */
    }
}
