using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieMVC.Models
{
    public class Movie
    {
        //public Movie()
        //{
        //    MovieTheaters = new Collection<MovieTheater>();
        //}

        public int MovieId { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        public ICollection<MovieTheater> MovieTheaters { get; set; }
    }
}