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
    private string rating;
    public Movie(string aName, string aDirector, string aRating)
    {
      name = aName;
      director = aDirector;
      Rating = aRating;
      //This capital R calls the setter below.
    }
    public string Rating
    {
      get { return rating; }
      set
      {
        if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
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