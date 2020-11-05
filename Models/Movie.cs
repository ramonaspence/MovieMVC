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

        public int ID { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }

        public string ReleaseState { get; set; }
        public string Image { get; set; }
        
        public string Genres { get; set; }

        public ICollection<MovieTheater> MovieTheaters { get; set; }
    }
}