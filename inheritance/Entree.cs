public class Entree : MenuItem
{

  public bool IsVegetarian { get; set; }
  public Entree(string name, decimal price, bool isVegetarian): base() 
  {
    Name = name;
    Price = price;
    IsVegetarian = isVegetarian;
  }

  public override void Display()
  {
    base.Display();
    Console.WriteLine($"  (Vegetarian: {IsVegetarian})");
  }
}
