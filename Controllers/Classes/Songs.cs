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
    // This is a static attribute. It is giving my info about the class in general. 
    // Not specific to the object itself.
    public Song(string aName, string aBand, int aDuration)
    {
      name = aName;
      band = aBand;
      duration = aDuration;
      songCount++;
    }

    public int getSongCount()
    {
      return songCount;
    }
    //Using this method you could now get the SongCount info from the specific object itself.

  }
}