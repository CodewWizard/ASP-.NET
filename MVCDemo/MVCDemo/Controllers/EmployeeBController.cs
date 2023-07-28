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
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post(Employee1 employee)
        {
            /*foreach(string key in formCollection.AllKeys)
            {
                Response.Write("key - " + key);
                Response.Write("  value - " + formCollection[key]);
                Response.Write("<br/>");
            }
            return View();*/
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.AddEmployee(employee);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee1 employee = employeeBusinessLayer.Employees.Single(emp => emp.EmpId == id);
            return View(employee);
        }
    }
}