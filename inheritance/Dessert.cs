public class Dessert : MenuItem
{
  public bool IsFrozen { get; }
  
  public Dessert(string name, decimal price, bool isFrozen) : base(name, price)
  {
    IsFrozen = isFrozen;
  }

  public override void Display()
  {
    base.Display();
    Console.WriteLine($"  (Frozen: {IsFrozen})");
  } 
}
