using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDIApp.DominClass
{
    public class EmployeeService : IEmployeeService
    {
        public string DisplayEmployees()
        {
            return "Dependency injection Example";
        }
    }
}
