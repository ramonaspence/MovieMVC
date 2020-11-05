using System;
namespace MovieMVC.Models
{
    public class MovieTheater
    {
        public int MovieID { get; set; }

        // navigation property
        public Movie Movie { get; set; }


        public int TheaterID { get; set; }
        public Theater Theater { get; set; }
    }
}
