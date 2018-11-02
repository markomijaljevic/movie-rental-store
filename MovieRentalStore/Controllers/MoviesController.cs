using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MovieRentalStore.Models;
using MovieRentalStore.ViewModel;
using System.Data.Entity;

namespace MovieRentalStore.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        [Route("Movies/Details/{id}")]
        public ViewResult MovieDetails(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            return View(movie);
        }

        public ActionResult Index()
        {

            var movies = _context.Movies.Include(c => c.Genre);

            return View(movies);
        }
    }
}