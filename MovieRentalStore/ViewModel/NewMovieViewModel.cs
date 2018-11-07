using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRentalStore.Models;

namespace MovieRentalStore.ViewModel
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }
        public Movies Movie { get; set; }
    }
}