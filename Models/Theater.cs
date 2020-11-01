using System;
using System.Collections.Generic;

namespace MovieMVC.Models
{
    public class MovieTheater
    {
        public MovieTheater()
        {
            this.Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }

        public string Title { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
