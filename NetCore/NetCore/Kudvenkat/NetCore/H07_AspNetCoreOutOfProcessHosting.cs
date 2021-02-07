using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Kudvenkat.NetCore
{
    public class H07_AspNetCoreOutOfProcessHosting
    {
        /*
            To configure OutOfProcess hosting there are two options:
            1. One option is to set the value of AspNetCoreHostingModel element to OutOfProcess.
            2. The other option is to remove AspNetCoreHostingModel element from the project file. The default is OutOfProcess hosting. So if AspNetCoreHostingModel
               element is not present in the project file then by default OutOfProcess hosting is used.
            
            With OutOfProcess hosting there are two Web Servers:
            1. An Internal Web Server
            2. An External Web Server
            
            The Internal Web Server is the Kestrel and the external Web Server can be IIS, NginX or Apache. Depending on how you are running your ASP.NET Core
            application the External Web Server may or may not be used.
            
            As we already know, Kestrel is a Cross-Platform Web Server that is embedded in our ASP.NET Core Application. With OutOfProcess hosting model Kestrel can
            be used in one of the following two ways:
            
            1. Kestrel can be used as the Internet facing Web Server that process the incoming HTTP request directly. In this model, we are not using an External
               Web Server only Kestrel is used and it is this server that faces the Internet to directly handle the incoming HTTP requests. So when we run our ASP.NET
               Core Application using the .NET Core CLI, Kestrel is the only Web Server that is used to handle and process the incoming HTTP requests. So in this
               model of hosting the process that's hosting and running our ASP.NET Core Application is dotnet.exe.
               
               If you change the AspNetCoreHostingModel element to OutOfProcess and then run the application through CLI by using "dotnet run" the output display now
               would be "dotnet". So, the name of the process that is hosting and running our ASP.NET Core Application is dotnet.
                                                                        Kestrel
               +--------------+               HTTP              +----------------------+
               |   Internet   |        <--------------->        |       dotnet.exe     |
               +--------------+                                 |  +-----------------+ |
                                                                |  |   Application   | |
                                                                |  +-----------------+ |
                                                                +----------------------+
            
            2. Another way Kestrel can be used is in combination with a reverse proxy server such as IIS, Nginx or Apache. In this model of hosting, Kestrel is not
               facing the Internet.
                                                                                                           Kestrel
                                                    +------------------------+                      +----------------------+
               +--------------+        HTTP         |  Reverse Proxy Server  |         HTTP         |       dotnet.exe     |
               |   Internet   |     <-------->      |                        |     <--------->      |  +-----------------+ |
               +--------------+                     |   IIS, Ngnix, Apache   |                      |  |   Application   | |
                                                    +------------------------+                      |  +-----------------+ |
                                                                                                    +----------------------+
               
               Between the Internet and the Kestrel server we have a Reverse Proxy Server such as IIS, Nginx or Apache. It is this Reverse Proxy Server that takes the
               incoming HTTP requests and forwards it to the Kestrel server that's hosting and running our ASP.NET Application.
               
               Now once the Kestrel server process the request it sends the response back to the Reverse Proxy Server and this Reverse Proxy Server in turn sends that
               response to the client who made that request.
            
            Q. At this point, you might be wondering well if Kestrel can be used by itself as a Web Server then why do we need this Reverse Proxy Server between the
               Client and our Internal Web Server Kestrel?
            
            A. Because a Reverse Proxy Server such as IIS provides an additional layer of configuration and security. It might integrate better with our existing
               infrastructure. It can also be used for load balancing.
            
               When we run an ASP.NET Core Application directly from Visual Studio by default it uses IISEXPRESS, so at the moment IISEXPRESS is acting as a Reverse
               Proxy Server. If you run the application from Visual Studio the process name still would be "dotnet" because at the moment IISEXPRESS is only acting
               as a Reverse Proxy Server. It is the Kestrel Server that is still hosting and running our ASP.NET Core Application.
            
               Important: When we run our ASP.NET Core project using the .NET Core CLI the hosting setting that we have specified in our project file is ignored,
                          irrespective of the value that we have in the AspNetCoreHostingModel. By default when we run this ASP.NET Core project using the .NET Core
                          CLI it's going to use OutOfProcess hosting because it's the Kestrel Server that's hosting and running our ASP.NET Core Application if we are
                          running our project using the .NET Core CLI.
               
                          To prove this, lets change the AspNetCoreHostingModel value to InProcess and run the project using the .NET Core CLI, the value of process
                          name would still be dotnet not the IISEXPRESS.
               
               Difference between InProcess and OutOfProcess Hosting?
               
               +--------------------------------------------------+--------------------------------------------------+
               |                InProcess                         |                   OutOfProcess                   |
               +--------------------------------------------------+--------------------------------------------------+
               |  Process name is w3wp.exe or iisexpress.exe      |  Process name is dotnet.exe                      |
               +--------------------------------------------------+--------------------------------------------------+
               |  Only one web server                             |  Two web servers (Internal and External)         |
               +--------------------------------------------------+--------------------------------------------------+
               |  Better for performance                          |  Penalty of proxying requests between internal   |
               |                                                  |  and external web server                         |
               +--------------------------------------------------+--------------------------------------------------+
            
            Q. Can we run an ASP.NET Core application without using the built-in Kestrel Web Server?
            A. Yes, if we use the InProcess hosting model the application is hosted inside of the IIS worker process that is w3wp.exe, so Kestrel is not used with
               InProcess hosting model.
        */
    }
}
