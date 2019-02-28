using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharppractice.FunnyBooks
{
  class FunnyBook
  {
    public string title;
    public string author;
    public int pages;

    public FunnyBook(string aTitle, string aAuthor, int aPages)
    {
      title = aTitle;
      author = aAuthor;
      pages = aPages;
    }
  }

}