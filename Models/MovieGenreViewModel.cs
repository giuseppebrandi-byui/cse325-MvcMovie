using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
  public List<Movie>? Movies { get; set; }
  public SelectList? Genres { get; set; }
  // public SelectList? ReleaseDate { get; set; }
  public string? MovieGenre { get; set; }
  // public System.DateTime? MovieDate { get; set; }
  public string? SearchString { get; set; }

}