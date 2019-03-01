using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharppractice.UsefulTools
{
  static class UsefulTool
  //The static means you cannot create an instance of it.
  {
    public static void SayHi(string name)
    {
      Console.WriteLine("Hello " + name);
    }
  }
}