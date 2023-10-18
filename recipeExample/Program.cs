using System;
using System.Collections.Generic;
using System.Text;

class Program
{
  static void Main()
  {
    var book = new RecipeBook();
    Console.WriteLine(book.GetRandomRecipe());
  }
}
