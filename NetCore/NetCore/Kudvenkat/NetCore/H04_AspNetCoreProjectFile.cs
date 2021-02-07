using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Kudvenkat.NetCore
{
    public class H04_AspNetCoreProjectFile
    {
        /*
            - The project file will have extension .csproj or .vbproj depending on the programming language used.
            
            - The format and the content of the .csproj file has significantly changed in ASP.NET Core.
            
            - One significant change is the way we edit a project file. In previous versions of ASP.NET, to be able to edit a project file we first have to unload a
              project from solution explorer and the way we do that is by right clicking on the project and click on the "Unload Project". This unloads the project
              and then we would be able to edit and save changes to the project file and then we have to reload the project.
            
            - In ASP.NET Core there is no need to unload the project. To edit a project file in ASP.NET Core, we need to right click on the solution and select
              "Edit ProjectName.csproj".
            
            - After opening the file you will notice how clean the file is.
            
            - Another significant change is, file or folder references are no longer included in the project file. In previous versions of ASP.NET, when we add a file
              or a folder to a project a reference to that file or folder is included in the project file.
            
            - But in ASP.NET Core, the file system determines what files and folders belong to the project. All files and folders that are present in the root project
              folder are by default part of the project and will be displayed in the Solution Explorer window. To validate this fact, you can add or delete a file
              in the File Explorer and simultaneously that particular file is reflected in the Solution Explorer.
            
            Understanding the content of the project file.
            
            - The first element in the project file is "TargetFramework". We use this element to specify the target framework for the application.
            
            - To specify a target framework we use Target Framework Moniker (TFM). The value we will see there is <TargetFramework>net5.0</TargetFramework>.
            
            - To understand the naming conventions used for these Target Framework Monikers. Below are the naming convention:
            
            +-------------------------+-------------------------+-------------------------+
            |          Name           |     Abbreviation        |           TFM           |
            +-------------------------+-------------------------+-------------------------+
            |     .NET Framework      |         net             |           net451        |
            |                         |                         |           net472        |
            +-------------------------+-------------------------+-------------------------+
            |     .NET Core           |      netcoreapp         |       netcoreapp1.0     |
            |                         |                         |       netcoreapp2.2     |
            +-------------------------+-------------------------+-------------------------+
            
            - The next element we have in the project file is "AspNetCoreHostingModel". This element specifies how the ASP.NET Core application should be hosted.
              Should it be hosted InProcess or OutOfProcess. The value of InProcess specifies that we want to use InProcess hosting model. That is host our ASP.NET
              Core App inside of the IIS worker process (w3wp.exe).
            
            - The value of OutOfProcess specifies that we want to use out of process hosting model i.e. forward web requests to a backend ASP.NET Core App running the
              kestrel server.
            
            - The default is OutOfProcess hosting.
            
            - The final element we have is "PackageReference" element. As the name specifies, we use this element to include a reference to the NuGet package that is
              installed for the application. As we develop and install more packages in our application, we would have more of these package reference elements.
            
            - The first package reference we have is - Microsoft.AspNetCore.App. This package is known as MetaPackage. A metapackage has no content of its own. It
              just contains a list of dependencies.
            
            - In the metapackage we usually do not contain a version number. When the version number is not specified, an implicit version is specified by the SDK.
            
            - .NET Core team specifies to rely on the implicit version rather than explicitly setting the version number on the package reference.
        */
    }
}
