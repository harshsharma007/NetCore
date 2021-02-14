using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Kudvenkat.NetCore
{
    public class H06_AspNetCoreInProcessHosting
    {
        /*
            Some of the Tasks that CreateDefaultBuilder() performs
            - Sets up the web server.
            - Loads the host and application configuration from various configuration sources and
            - Configure logging
            
            An ASP.NET Core application can be hosted
            - InProcess or
            - OutOfProcess
            
            To configure InProcess hosting for your application there is one simple setting:
            - Include the below line in project file of your application
              <AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>
            
            - CreateDefaultBuilder() method calls UseIIS() method and host the app inside of the IIS worker process (w3wp.exe or iisexpress.exe). The worker process
              name in case of IIS is w3wp.exe and in case of IISExpress it's iisexpress.exe
            
            - From a performance stand point, InProcess hosting delivers significantly higher request throughput than OutOfProcess hosting.
            
            - To get the process name executing the app
              System.Diagnostics.Process.GetCurrentProcess().ProcessName
            
            - The name of the process that's hosting and running our ASP.NET Core application is IISEXPRESS. Why IISExpress? That's because at the moment we are
              running our project from Visual Studio. By default Visual Studio uses IISEXPRESS to host and run our application. As you might already know, IISEXPRESS
              is a light-weight self-contained version of IIS optimized especially for developing applications. We don't use IISEXPRESS in production, in production
              we use IIS. If we have used IIS instead of IISEXPRESS then the process name displayed by the above code would be w3wp.
            
            With OutOfProcess hosting there are two servers involved
            - Internal Web Server and an External Web Server.            
            - The Internal Web Server is Kestrel.            
            - And the External Web Server can be IIS, Nginx or Apache.
            
            On the other hand, with InProcess hosting there is only one Web Server i.e. The IIS that hosts the ASP.NET Core Applications. So, with InProcess hosting
            we do not have the performance penalty of proxying request between Internal and External Web Server.
            
            What is Kestrel?
            - Kestrel is a Cross-Platform Web Server for ASP.NET Core. It is supported on all platforms and versions that .NET Core supports. It's included by default
              as an Internal server in ASP.NET Core.
            
            - Kestrel can be used by itself as an edge server that is Internet Facing Web Server that can directly process incoming HTTP requests from the client.
            
            - The name of the process in Kestrel that hosts and runs our ASP.NET Core Application is dotnet.exe.
            
            We can also run our application from Command Line using the .NET Core CLI. CLI stands for Command Line Interface. .NET Core CLI is a cross-platform tool
            for developing .NET Core Applications. It's supported on all platforms Windows, MAC OS and all other platforms where .NET Core is supported.
            
            dotnet --health
            This command will show you all the commands available for .NET Core.
            
            To be able to run our project using the .NET Core CLI, change the directory to the folder that contains our project. When you have entered the folder
            location execute the below command:
            
            dotnet run
            
            This command will build and run our ASP.NET Core project using the .NET Core CLI. Important: When a .NET Core application is executed using the .NET
            Core CLI, Kestrel is used as the Web Server. And remember in Kestrel the name of the process that hosts and runs our application is dotnet.exe and when
            you run an application using a CLI the name of the Process would be dotnet.exe.
            
            But now from Core 2.2, the process name is the profile name specified in launchSettings.json.
        */
    }
}
