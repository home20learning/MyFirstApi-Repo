using AngularCoreApiOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AngularCoreApiOne.Repos
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeInfo GetEmployee(int id)
        {
            EmployeeInfo empInfo = new EmployeeInfo();
            empInfo.empId = 5;
            empInfo.empName = "Lokes";
            empInfo.empDesg = "SM";

            return empInfo;
        }

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
