using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web;
using BusinessLayer;

namespace MVCDemo.Controllers
{
    public class EmployeeBController : Controller
    {
        // GET: EmployeeB
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = employeeBusinessLayer.Employees.ToList();

            return View(employees);
        }
    }
}