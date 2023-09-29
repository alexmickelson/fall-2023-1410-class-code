public class Entree : MenuItem
{
  public bool IsVegetarian { get; set; }
  public Entree(string name, decimal price, bool isVegetarian): base() 
  {
    Name = name;
    Price = price;
    DisplayText = $"- {name}: ${price}\n  (Vegetarian: {isVegetarian})";
    IsVegetarian = isVegetarian;
  }
}
