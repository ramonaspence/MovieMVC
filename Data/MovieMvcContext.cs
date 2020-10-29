using Microsoft.EntityFrameworkCore;
using MovieMVC.Models;

namespace MovieMVC.Data
{
    public class MovieMvcContext : DbContext
    {
        public MovieMvcContext(DbContextOptions<MovieMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}