using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapaneseChefs;
using Microsoft.AspNetCore.Mvc;

namespace KoreanChefs
{
  class KoreanChef : JapaneseChef
  {
    public void MakeKimchi()
    {
      Console.WriteLine("This mofo makes Kimchi");
    }
  }
}