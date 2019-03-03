using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Movies
{
  class Movie
  {
    public string name;
    public string director;
    public string rating;
    public Movie(string aName, string aDirector, string aRating)
    {
      name = aName;
      director = aDirector;
      rating = aRating;
    }
  }
}