using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharppractice.Songs
{
  class Song
  {
    public string name;
    public string band;
    public int length;
    public Song(string aName, string aBand, int aLength)
    {
      name = aName;
      band = aBand;
      length = aLength;

    }
  }
}