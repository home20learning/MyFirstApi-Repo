using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCoreApiOne.Models;
using AngularCoreApiOne.Repos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AngularCoreApiOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
               public EmployeeInfo Get()
        {
            return employeeRepository.GetEmployeeList();

        }

       
    }
}