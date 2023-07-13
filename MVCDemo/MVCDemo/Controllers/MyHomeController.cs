using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class MyHomeController : Controller
    {
        // GET: MyHome
        public string Index(string id, string name)
        {
            return "Hello from MVC Application and Id - " + id + " Name - " + name;
        }

        // url = controller/actionMethod
        // url = MyHome/getDetails
        public string GetDetails()
        {
            return "get details in mvc";
        }

        // url = MyHome/listOfCountries
        public ActionResult ListOfCountries()
        {
            ViewBag.Countries = new List<string> 
            {
                "India",
                "United States",
                "United Kingdom"
            };
            return View();
        }
    }
}