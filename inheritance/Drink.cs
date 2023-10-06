public class Drink : MenuItem
{
  public string Size { get; }
  
  public Drink(string name, decimal price, string size)
    : base(name, price)
  {
    Size = size;
  }

  public override void Display()
  {
    base.Display();
    Console.WriteLine($"  (Size: {Size})");
  }

}
