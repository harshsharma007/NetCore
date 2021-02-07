using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Kudvenkat.NetCore
{
    public class H01_WhatIsAspNetCore
    {
        /*
            What is ASP.NET Core
            ASP.NET Core is a cross-platform, high-performance, open-source framework for building modern cloud-based, Internet-connected applications.
            It's a redesign of the previous version of ASP.NET 4.x. Due to this reason ASP.NET Core was initially called ASP.NET 5 but later renamed to ASP.NET Core 1.0
            
            ASP.NET Core Benefits and Features
            1. Cross Platform - ASP.NET 4.x can run only on windows platform whereas ASP.NET Core applications can be developed and run across different platforms
               like:
               - Windows
               - macOS
               - Linux
               
               Hosting - From a hosting stand point, ASP.NET 4.x applications can be hosted only on IIS whereas ASP.NET Core applications can be hosted on:
               - IIS
               - Apache
               - Docker
               - Self-host in your own process
            
               From the development point of view, you can either use Visual Studio, Visual Studio Code or any other 3rd party IDE.
            
            2. One Programming Model for MVC and Web API - Because of this one unified programming model, both the MVC Controller class and the ASP.NET Web API
               Controller class inherit from the same Controller base class and returns IActionResult.
               
               IActionResult is an interface and it has got several implementations the two types here are just two best examples of the built-in result type that
               implement this IActionResult interface:
               - ViewResult
               - JsonResult
               
               In the case of Web API the controller class will return JsonResult but in the case of MVC application the same controller class might return ViewResult.
            
            3. Built-in support for Dependency Injection
            
            4. Testability
            
            5. Open-Source and Community focused
            
            6. Modular - ASP.NET Core provides Modularity with Middleware Components. We use these Middleware Components to compose both the request and response
               pipelines. ASP.NET Core includes a rich set built-in middleware components. We can also create our custom middleware components.
        */
    }
}
