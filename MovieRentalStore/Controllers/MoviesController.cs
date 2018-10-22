using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MovieRentalStore.Models;
using MovieRentalStore.ViewModel;

namespace MovieRentalStore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movies() {Name = "Iron Man"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Marko"},
                new Customer {Name = "Luka"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers 
            };

            return View(viewModel);
        }

        [Route("movies/released/{year:regex(\\d{4}):range(2000,2018)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Index()
        {
            var movies = new List<Movies>
            {
                new Movies {Id = 1, Name = "Iron Man"},
                new Movies {Id = 1, Name = "Batman"},
                new Movies {Id = 1, Name = "Gravity"}
            };

            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }
    }
}