using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharppractice.Chefs
// Chef is the super class.
{
  class Chef
  {
    public void MakeChicken()
    // This is method.
    {
      Console.WriteLine("The Chef makes chicken");
    }
    public void MakeSalad()
    {
      Console.WriteLine("The Chef makes salad");
    }
    public void MakeSpecialDish()
    {
      Console.WriteLine("The Chef makes bbq ribs");
    }
  }
}