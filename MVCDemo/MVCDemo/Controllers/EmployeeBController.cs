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
        public ActionResult Create_Post(int EmpId, string EmpName, string EmpCity, string EmpGender, int DepartmentId)
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

                Employee1 employee = new Employee1();
                UpdateModel(employee);

                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.AddEmployee(employee);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}