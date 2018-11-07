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

        public ActionResult New()
        {
            var viewModel = new NewMovieViewModel
            {
                Genre = _context.Genre
            };
       
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new NewMovieViewModel
            {
                Genre = _context.Genre,
                Movie = movie
            };

            return View("New", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movies movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now.Date;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.GenreId = movie.GenreId;
                movieInDb.Name = movie.Name;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}