using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDetails.Models;
using EmployeeDetails.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDetails.Controller
{
    [Route("api/")]
    [ApiController]
    public class EmployeeListController : ControllerBase
    {
       private List<EmployeeForm> employee = new List<EmployeeForm>()
            {
                new EmployeeForm{EmployeeName="sam",EmployeeType="full-time"},
                new EmployeeForm{EmployeeName="john",EmployeeType="part-time"},
                new EmployeeForm{EmployeeName="akhil",EmployeeType="contract"},
                new EmployeeForm{EmployeeName="nikhil",EmployeeType="full-time"},
                new EmployeeForm{EmployeeName="mike",EmployeeType="full-time"},
                new EmployeeForm{EmployeeName="priya",EmployeeType="full-time"},
                new EmployeeForm{EmployeeName="kiran",EmployeeType="part-time"},
                new EmployeeForm{EmployeeName="nehal",EmployeeType="full-time"},
                new EmployeeForm{EmployeeName="sai",EmployeeType="contract"},
                new EmployeeForm{EmployeeName="joy",EmployeeType="full-time"}

            };
        //private readonly IEmployeeServices _services;

        //public EmployeeListController(IEmployeeServices services)
        //{
        //    var data= services;
        //}
        /*  [HttpPost]
          [Route("AddEmployee")]
          public ActionResult<EmployeeForm> AddEmployee(EmployeeForm items)
          {
              var emp = services.AddEmployee(items);

              if (emp == null)
              {
                  return NotFound();
              }
              return emp;
          }*/
        [HttpGet]
        [Route("GetEmployeeDetails")]

        public IActionResult GetEmployeeDetails()
        {
            //List<EmployeeForm> employee = new List<EmployeeForm>()
            //{
            //    new EmployeeForm{EmployeeName="sam",EmployeeType="full-time"},
            //    new EmployeeForm{EmployeeName="john",EmployeeType="part-time"},
            //    new EmployeeForm{EmployeeName="akhil",EmployeeType="contract"},
            //    new EmployeeForm{EmployeeName="nikhil",EmployeeType="full-time"},
            //    new EmployeeForm{EmployeeName="mike",EmployeeType="full-time"},
            //    new EmployeeForm{EmployeeName="priya",EmployeeType="full-time"},
            //    new EmployeeForm{EmployeeName="kiran",EmployeeType="part-time"},
            //    new EmployeeForm{EmployeeName="nehal",EmployeeType="full-time"},
            //    new EmployeeForm{EmployeeName="sai",EmployeeType="contract"},
            //    new EmployeeForm{EmployeeName="joy",EmployeeType="full-time"}

            //};
            return Ok(employee);

        }
            

    }
}