using System;
using System.Collections.Generic;

namespace MovieMVC.Models
{
    public class Theater
    {
        public int TheaterId { get; set; }

        public string Title { get; set; }
        public string Location { get; set; }

        // MovieTheaters is a collection of Movie-To-Theater relationships.
        public ICollection<MovieTheater> MovieTheaters { get; set; }
    }
}
