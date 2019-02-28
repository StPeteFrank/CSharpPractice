using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharppractice.ComicBooks
{
  class Comic
  {
    public string title;
    public int issue;

    public Comic(string aTitle, int aIssue)
    {
      title = aTitle;
      issue = aIssue;
    }

  }
}