using AngularCoreApiOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCoreApiOne.Repos
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeInfo GetEmployeeList()
        {
            EmployeeInfo empInfo = new EmployeeInfo();
            empInfo.empId = 1;
            empInfo.empName = "Lokeshj";
            empInfo.empDesg = "manager";

            return empInfo;
        }
    }
}
