using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharppractice.Chefs;
using ItalianChefs;
using Microsoft.AspNetCore.Mvc;

namespace JapaneseChefs
{
  class JapaneseChef : ItalianChef
  {
    public void MakeSushi()
    {
      Console.WriteLine("The japanese chef makes sushi");
    }
    public void MakeSashimi()
    {
      Console.WriteLine("The japanese chef makes sashimi");
    }
  }
}