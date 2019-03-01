using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharppractice.UsefulTools
{
  class UsefulTool
  {
    public static void SayHi(string name)
    {
      Console.WriteLine("Hello " + name);
    }
  }
}