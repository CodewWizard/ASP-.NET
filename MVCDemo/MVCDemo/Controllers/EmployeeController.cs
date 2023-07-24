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

        public ActionResult Index(int departmentId)
        {
            EmployeeContext empContext = new EmployeeContext();
            List<Employee> employees = empContext.Emps.Where(emp => emp.DepartmentID == departmentId).ToList();

            return View(employees);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext empContext = new EmployeeContext();
            Employee em = empContext.Emps.Single(emp => emp.EmpId == id);
            return View(em);
        }
    }
}