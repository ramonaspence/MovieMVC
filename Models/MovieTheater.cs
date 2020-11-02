using System;
namespace MovieMVC.Models
{
    public class MovieTheater
    {
        public int MovieId { get; set; }

        // navigation property
        public Movie Movie { get; set; }


        public int TheaterId { get; set; }
        public Theater Theater { get; set; }
    }
}
