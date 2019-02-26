using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharppractice.Books
{
  class Book
  // This is a class.
  {
    public string title;
    public string author;
    public int pages;

    // These are class attributes.

    public Book(string aTitle, string aAuthor, int aPages)
    {
      title = aTitle;
      author = aAuthor;
      pages = aPages;
    }
    // This is a constructor.

  }
}