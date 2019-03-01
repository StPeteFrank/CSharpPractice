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
    public int duration;
    public static int songCount = 0;
    // this is a static attribute. 
    public Song(string aName, string aBand, int aDuration)
    {
      name = aName;
      band = aBand;
      duration = aDuration;
      songCount++;

    }
  }
}