using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Kudvenkat.NetCore
{
    public class H18_ModelInAspNetCoreMvc
    {
        /*
            We want to retrieve specific employee details from the Employee database table and display those details on a web page. Model in MVC contains set of classes
            that represent data and the logic to manage the data. In our case, we want to work with Employee data. So to represent Employee data, I'm going to create
            an Employee class and this Employee class is going to contain the properties (Name, Email & Department). To be able to uniquely identify each Employee, we
            are also going to have ID property.
            
            Now let's place our Model classes in a folder called Models within our project. In ASP.NET Core MVC, Model and Controller classes does not have to
            necessarily be in the folders named Models and Controllers. They can literally live anywhere within the project but it's a good practice to place them in
            their respective folders because it's easier to find them later.
            
            Remember: A Model in MVC contains set of classes that represent data and the logic to manage the data in our case this Employee class represents the
            Employee data we want to work with.
            
            After creating the Employee class in Models folder, we want another class that's going to manage these employee details that is saving and retrieving these
            employee details from an underlying data source such as a database table. So, we have to add Interface instead of a class. The name of the interface would
            be IEmployeeRepository and this interface is going to contain only one method that is going to retrieve a specific Employee by Id.
            
            Reason for using Interface: If you take a look at the interface it doesn't have much code in it. All it has the declaration of this method GetEmployee.
            All of the work has been done by our MockEmployeeRepository class, which is providing the implementation for the GetEmployee() method. So the obvious
            question that comes to our mind is why are we using the Interface IEmployeeRepository in between? Why don't we directly program against this
            MockEmployeeRepository class?
            
            We can use this MockEmployeeRepository class without the interface if we want but if we do that we cannot use Dependency Injection and as a result our
            application will be extremely difficult to change and maintain. Unit testing also becomes very difficult. So throughtout our application we will be
            programming againt this interface IEmployeeRepository and not against any concrete implementation such as this MockEmployeeRepository. This allows us to
            use Dependency Injection which in turn allows our application to be more flexible and easily unit testable.
            
            To update and delete employees, we need to provide implementation for this Interface IEmployeeRepository. So, to Models folder we are going to add another
            class with the name MockEmployeeRepository. This class is going to provide the implementation for IEmployeeRepository.
            
            Now, we are going to create a constructor in the HomeController class. Using this constructor we are going to inject this Interface IEmployeeRepository.
            In ASP.
        */
    }
}
