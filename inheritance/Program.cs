using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    var menu = new Menu();
    menu.Add(new Entree("Burger", 8.99m, false));
    menu.Add(new Entree("Vegetable Pizza", 7.99m, true));
    menu.Add(new Dessert("Ice Cream", 3.99m, true));
    menu.Add(new Drink("Soda", 1.99m, "Medium"));

    Console.WriteLine(menu);
  }
}
