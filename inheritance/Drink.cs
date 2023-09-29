public class Drink : MenuItem
{
  public string Size { get; }
  
  public Drink(string name, decimal price, string size)
      : base(name, price, $"- {name}: ${price}\n  (Size: {size})")
  {
    Size = size;
  }

}
