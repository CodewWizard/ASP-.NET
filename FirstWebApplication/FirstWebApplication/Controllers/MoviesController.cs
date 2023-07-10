using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebApplication.Models;

namespace FirstWebApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()    
        {
            var movie1 = new Movie()
            {
                Name = "Madiha"
            };
            return View(movie1);
            //return Content("This returns from Content Result");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page=1, sortBy="name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Dummy Name";

            return Content(String.Format("pageIndex = {0} & sortBy = {1}", pageIndex, sortBy));
        }
    }
}