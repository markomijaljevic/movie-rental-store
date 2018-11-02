﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalStore.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public short NumberInStock { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}