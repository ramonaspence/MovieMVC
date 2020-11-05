using System.Collections;
using Microsoft.EntityFrameworkCore;
using MovieMVC.Models;

namespace MovieMVC.Data
{
    public class MovieMvcContext : DbContext
    {
        public DbSet<Movie> Movie { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<MovieTheater> MovieTheaters { get; set; }

        public MovieMvcContext(DbContextOptions<MovieMvcContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieTheater>()
                .HasKey(mt => new { mt.MovieID, mt.TheaterID });
        }

    }
}