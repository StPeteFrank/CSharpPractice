using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharppractice.Chefs;
using Microsoft.AspNetCore.Mvc;

namespace ItalianChefs
{
  class ItalianChef : Chef
  // ItalianChef id the subclass.
  {
    public void MakePasta()
    {
      Console.WriteLine("The italian chef makes a da pasta!");
    }
  }
}