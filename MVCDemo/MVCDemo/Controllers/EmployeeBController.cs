using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BusinessLayer;
using System;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeBController : Controller
    {
        // GET: EmployeeB
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee1> employees = employeeBusinessLayer.Employees.ToList();

            return View(employees);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            /*foreach(string key in formCollection.AllKeys)
            {
                Response.Write("key - " + key);
                Response.Write("  value - " + formCollection[key]);
                Response.Write("<br/>");
            }
            return View();*/

            Employee1 employee = new Employee1();
            employee.EmpId = Convert.ToInt32(formCollection["EmpId"]);
            employee.EmpName = formCollection["EmpName"];
            employee.EmpCity = formCollection["EmpCity"];
            employee.EmpGender = formCollection["EmpGender"];
            employee.DepartmentId = Convert.ToInt32(formCollection["DepartmentId"]);

            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.AddEmployee(employee);

            return RedirectToAction("Index");
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}