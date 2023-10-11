public class Dessert : MenuItem
{
  public bool IsFrozen { get; }
  
  public Dessert(string name, decimal price, bool isFrozen) : base(name, price)
  {
    IsFrozen = isFrozen;
  }

  public override string ToString()
  {
    var outputString = base.ToString() + Environment.NewLine;
    outputString += $"  (Frozen: {IsFrozen})";
    return outputString;
  }
}
