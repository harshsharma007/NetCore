using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Kudvenkat.NetCore
{
    public class H09_AspNetCoreAppSettingsJson
    {
        /*
            In previous versions of ASP.NET, we store application configuration settings like database connection strings in web.config file. In ASP.NET Core,
            configuration information can come from different configuration sources and below are the configuration sources:
            - Files (appsettings.json, appsettings.{Environment}.json)
            - User secrets
            - Environment variables
            - Command-line arguments
            
            appsettings.json
            Let's add a new key value pair in the appsettings.json file. The key would be "MyKey" and the value would be "Value of MyKey from appsettings.json". To
            read this key value from the code, ASP.NET Core provides us with IConfiguration Service. By default this service is set up in such a way, it knows how to
            read configuration information from all these different configuration sources i.e. files, user secrets, environment variables and command line arguments.
            
            We can acess this key in the Startup.cs file. The first thing we would do here is inject IConfiguration serivce provided by the framework into the Startup
            class. For that we need a constructor, to get the constructor type "ctor" and press tab twice. We are going to use constructor injection to inject
            IConfiguration service into this startup class.
            
            IConfiguration service is present in Microsoft.Extensions.Configuration namespace. We are using Dependency Injection to inject IConfiguration service, in
            previous versions of ASP.NET Dependency Injection was optional and to configure it we have to use external frameworks such as structure map etc. In ASP.NET
            Core Dependency Injection is an integral part, Dependency Injection allows us to create systems that are loosely coupled, extensible and easily testable.
            
            In addition to appsettings.json file we may also have environment specific appsettings.json file e.g. for development environment we may have
            appsettings.development.json. Similarly, for production we may have appsettings.production.json and for staging appsettings.staging.json.
            
            Important: The settings in appsettings.{Environment}.json file will overwrite the settings in appsettings.json file.
            
            If we expand the appsettings.json file, we will see there is appsettings.development.json file also. The settings in this development environment file are
            going to override the settings that we have in appsettings.json. To prove this, copy "MyKey" to the development file with different value.
            
            Environment Variables
            In launchsettings.json file, we already have "environmentVariables" which contains the value of ASPNETCORE_ENVIRONMENT. In addition to this variable, lets
            include another environment variable with the name "MyKey" and with a different value.
            
            Important: IConfiguration service provided by the framework will read the configuration information that's present in these configuration sources in the
            order that is specified below:
            1. Files
            2. User secrets
            3. Environment variables
            4. Command-line arguments
            
            It means that the same settings exist in appsettings.json and appsettings.Development.json file, then appsettings.json settings will be overwritten.
            Similarly, user secrets will overwrite file settings, environment variables will overwrite user secrets and command-line arguments will overwrite
            environment variables. So the point is later configuration sources override the settings that are present in the earlier configuration sources. To prove
            this, lets keep the same key in appsettings.json, appsettings.Development.json and launchSettings.json file (environment variables). Value of
            launchSettings.json will be displayed.
            
            Command-line Arguments
            To run the project from command-line, execute the below command:
                dotnet run MyKey="Value from Command Line"
            So, command-line will overwrite all the prior settings.
            
            In our Program.cs file, we have Main method which is the entry point into the application. This method calls CreateWebHostBuilder, which in turn calls
            CreateDefaultBuilder, CreateDefaultBuilder is the method that sets up the default order in which all these different configuration sources are read.
        */
    }
}
