using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalStore.Models
{
    public class Movies
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1,50)]
        public short NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }
    }
}