using AngularCoreApiOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCoreApiOne.Repos
{
    public interface IEmployeeRepository
    {
        public EmployeeInfo GetEmployeeList();
    }
}
