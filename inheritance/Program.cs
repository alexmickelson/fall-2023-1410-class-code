using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    List<MenuItem> menuItems = new List<MenuItem>
    {
      new Entree("Burger", 8.99m, false),
      new Entree("Vegetable Pizza", 7.99m, true),
      new Dessert("Ice Cream", 3.99m, true),
      new Drink("Soda", 1.99m, "Medium")
    };

    Console.WriteLine("Welcome to Our Restaurant!");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Menu:");
    foreach (var item in menuItems)
    {
      item.Display();
    }
  }
}
