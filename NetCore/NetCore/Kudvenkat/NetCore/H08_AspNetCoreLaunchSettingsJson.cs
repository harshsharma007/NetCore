using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Kudvenkat.NetCore
{
    public class H08_AspNetCoreLaunchSettingsJson
    {
        /*
            You will find this find in Properties folder in Solution Explorer. The settings in this file are used when we run the ASP.NET Core project from Visual
            Studio or by using .NET Core CLI.
            
            The important point to keep in mind is this file is only required on our local development machine we do not need it for publishing our ASP.NET Core
            application. If there are certain settings that you want your ASP.NET Core application to use when you publish and deploy your app, store those settings
            in this AppSettings.json file. We usually store our application configuration settings in this file. We can also have environment specific AppSettings.json
            files e.g. AppSettings.Staging.json for the staging envrionment.
            
            Similarly, for development environment we'll have AppSettings.development.json. In addition to these AppSettings.json files we also have other configuration
            sources like environment variables, command line arguments and even our own custom configuration source.
            
            In our launchSettings.json file, we have two profiles:
            - "IIS Express"
            - The other name is same as the name of our project.
            
            When we run this project from Visual Studio, then "IIS Express" profile is used. When you run the project check the port number in the address bar is 15410.
            The port number is configured in our launch profile "IIS Express" and the setting for this profile is above it in the "applicationUrl", there you would see
            port number 15410. We can also configure "sslPort".
            
            In the profile, we can also configure "environmentVariables" by configuring "ASPNETCORE_ENVIRONMENT" to "Development". We can change this value to "Staging"
            or "Production" depending on whether we are running the project in staging or production envrionment. You can also add new environment variables, these
            environment variables are available throughout our ASP.NET Core application and we can include code that conditionally executes depending on a value of
            these environment variables e.g. if you take a look at Startup.cs file, in the Configure() method we are checking if the environment is development. Since
            we have set the environment variable to development this condition is going to return true and code in the if condition will gets executed, meaning on a
            development environment developer exception page is displayed.
            
            If we are running the same App on the staging environment, then on that staging environment will set the environment variable to "Staging". That means the
            condition where we were checking IsDevelopment is going to return false and that means on some other environment some other page will be displayed.
            
            LaunchSettings.json file consists of the launch profiles to launch and run our ASP.NET Core project on our local development machine. At the moment, the
            launchSettings.json file contains two profiles.
            - "IIS Express" is used whenever we run our project through Visual Studio.
            - The other profile is the name of the profile, which will be used when we run this ASP.NET Core project using the .NET Core CLI. If you run the code
              using .NET CLI, you will notice the port number for running and listening the incoming HTTP request is 5000. And, this port number is configured in
              the second profile. This proves when we run our project using .NET Core CLI the second profile is used.
            
            The drop which contains the options of profiles such as "IIS Express", Web Browsers (Google Chrome, IE) and many more will also consists of the profiles
            that are mentioned in the launchSettings.json. If we choose the "Project Name" profile from the dropdown and run the project, Visual Studio launches
            .NET Core CLI and .NET Core CLI runs our project. After choosing the option, if you again run the project you will notice that .NET Core CLI runs and
            then the project is loaded. Moreover, the port number would now be 5000.
            
            In our project file, the element AspNetCoreHostingModel value along with the "commandName" value in launchSettings.json determines the internal and external
            Web Server to use. The "commandName" can have a value such as IIS Express, Project, IIS, NginX.
            
            +------------------------------+------------------------------+------------------------------+------------------------------+
            |       commandName            |    AspNetCoreHostingModel    |    Internal Web Server       |     External Web Server      |
            +------------------------------+------------------------------+------------------------------+------------------------------+
            | Project                      | Hosting Setting Ignored      |             Only one web server - Kestrel                   |
            +------------------------------+------------------------------+-------------------------------------------------------------+
            | IISExpress                   | InProcess                    |             Only one web server - IIS Express               |
            +------------------------------+------------------------------+-------------------------------------------------------------+
            | IISExpress                   | OutOfProcess                 |             Kestrel          |    IIS Express               |
            +------------------------------+------------------------------+-------------------------------------------------------------+
            | IIS                          | InProcess                    |             Only one web server - IIS                       |
            +------------------------------+------------------------------+-------------------------------------------------------------+
            | IIS                          | OutOfProcess                 |             Kestrel          |    IIS                       |
            +------------------------------+------------------------------+-------------------------------------------------------------+
        */
    }
}
