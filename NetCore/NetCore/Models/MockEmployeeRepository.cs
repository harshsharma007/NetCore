using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = "HR", Email = "mary@pragimtech.com" },
                new Employee() { Id = 2, Name = "John", Department = "IT", Email = "john@pragimtech.com" },
                new Employee() { Id = 3, Name = "Sami", Department = "IT", Email = "sami@pragimtech.com" }
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == Id);
        }
    }
}
