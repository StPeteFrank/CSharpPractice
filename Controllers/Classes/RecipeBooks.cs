using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharppractice.RecipeBooks
{
  class RecipeBook
  {
    public string title;
    public string author;
    public int pages;
    public int numberOfRecipes;

    public RecipeBook(string aTitle, string aAuthor, int aPages, int aNumberOfRecipes)
    {
      title = aTitle;
      author = aAuthor;
      pages = aPages;
      numberOfRecipes = aNumberOfRecipes;
    }
  }
}