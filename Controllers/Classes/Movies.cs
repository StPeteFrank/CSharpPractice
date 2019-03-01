using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharppractice.Movies
{
  class Movie
  {
    public string title;
    public string director;

    public string rating;

    public Movie(string aTitle, string aDirector, string aRating)
    {
      title = aTitle;
      director = aDirector;
      rating = aRating;
    }
  }
}