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
      Rating = aRating;
      // When you set this capital R, it is calling the Rating special method below. Then it needs to be called
      //   with the capital R in Main.
    }
    public string Rating
    // properties are like a special method
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

  }
}