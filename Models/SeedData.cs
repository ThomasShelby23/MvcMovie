
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using MvcMovie.Migrations;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Harry Potter",
                    ReleaseDate = DateTime.Parse("1999-2-12"),
                    Genre = "Sci-Fi",
                    Price = 8,
                    Rating = "8"
                },
                new Movie
                {
                    Title = "Peaky Blinder",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Sci Fiction",
                    Price = 100,
                    Rating = "9.5"
                },
                  new Movie
                  {
                      Title = "Fifty shades of grey ",
                      ReleaseDate = DateTime.Parse("2014-9-11"),
                      Genre = "Romantic",
                      Price = 100,
                      Rating = "7.8"
                  },
                new Movie
                {
                    Title = "Lost in the star ",
                    ReleaseDate = DateTime.Parse("2016-7-11"),
                    Genre = "Romantic",
                    Price = 9,
                    Rating = "7"
                }, 
                new Movie 
                {
                    Title = "Avengers",
                    ReleaseDate = DateTime.Parse("2014-1-7"),
                    Genre = "Action",
                    Price = 10,
                    Rating = "9.5"
                } 
                
            );
            context.SaveChanges();
        }
    }
}