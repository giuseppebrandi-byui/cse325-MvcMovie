using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
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
            Title = "When Harry Met Sally",
            ReleaseDate = DateTime.Parse("1989-2-12"),
            Genre = "Romantic Comedy",
            Price = 7.99M,
            Rating = "R"
          },
          new Movie
          {
            Title = "Ghostbusters ",
            ReleaseDate = DateTime.Parse("1984-3-13"),
            Genre = "Comedy",
            Price = 8.99M,
            Rating = "R"
          },
          new Movie
          {
            Title = "Ghostbusters 2",
            ReleaseDate = DateTime.Parse("1986-2-23"),
            Genre = "Comedy",
            Price = 9.99M,
            Rating = "R"
          },
          new Movie
          {
            Title = "Rio Bravo",
            ReleaseDate = DateTime.Parse("1959-4-15"),
            Genre = "Western",
            Price = 3.99M,
            Rating = "R"
          },
          new Movie
          {
            Title = "Rambo - First Blood",
            ReleaseDate = DateTime.Parse("1982-12-16"),
            Genre = "Action",
            Price = 7.98M,
            Rating = "R"
          },
          new Movie
          {
            Title = "Rambo - First Blood Part 2",
            ReleaseDate = DateTime.Parse("1985-05-22"),
            Genre = "Action",
            Price = 7.99M,
            Rating = "R"
          },
          new Movie
          {
            Title = "Rambo III",
            ReleaseDate = DateTime.Parse("1988-2-26"),
            Genre = "Action",
            Price = 15.00M,
            Rating = "R"
          }
      );
      context.SaveChanges();
    }
  }
}