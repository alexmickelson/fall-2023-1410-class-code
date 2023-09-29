public class Dessert : MenuItem
{
  public bool IsFrozen { get; }
  
  public Dessert(string name, decimal price, bool isFrozen)
      : base(name, price, $"- {name}: ${price}\n  (Frozen: {isFrozen})")
  {
    IsFrozen = isFrozen;
  }
}
