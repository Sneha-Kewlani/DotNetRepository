using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AspWebAPI.Models;

namespace AspWebAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        Employee[] employees = new Employee[]
        {
            new Employee {ID = 1, Name = "Jack", age=23 },
            new Employee {ID = 2, Name = "Sneha", age=21 },
            new Employee {ID = 3, Name = "Cup", age=2 },
        };

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault((p) => p.ID == id);
            if(employee==null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }
}
