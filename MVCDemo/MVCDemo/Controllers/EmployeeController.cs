using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        /*public ActionResult Details(int id)
        {
            EmployeeContext empContext = new EmployeeContext();
            Employee employee = empContext.Emps.Single(e => e.Id == id);
            return View(employee);
        }*/

        public ActionResult Details()
        {
            Employee emp = new Employee()
            {
                Id = 101,
                Name = "Madiha",
                City = "Solapur"
            };
            return View(emp);
        }
    }
}