using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebApplication.Models;

namespace FirstWebApplication.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { id = 1, name = "John Smith" },
                new Customer { id = 2, name = "Mary Williams" }
            };
        }
    }
}