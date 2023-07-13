using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebApplication.Models;
using FirstWebApplication.ViewModels;

namespace FirstWebApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        /*public ActionResult Random()    
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
        }*/

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        /*public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Dummy Name";

            return Content(String.Format("pageIndex = {0} & sortBy = {1}", pageIndex, sortBy));
        }*/


        // attribute routes
        //[Route("movies/release/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + " / " + month);
        }

        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "3 Idiots"
            };

            var customers = new List<Customer>
            {
                new Customer { name = "Customer-1"},
                new Customer {name = "Customer-2"  }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shark"},
                new Movie {Id = 2, Name = "Titanic"}
            };
        }
    }
}