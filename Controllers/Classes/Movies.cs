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
    private string rating;
    public Movie(string aTitle, string aDirector, string aRating)
    {
      title = aTitle;
      director = aDirector;
      rating = aRating;
    }
    public string Rating
    {
      get { return rating; }
      set
      {
        if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
        {
          rating = value;
        }
        else
        {
          rating = "NR";
        }
      }
    }


    // properties is like a special method
  }
}