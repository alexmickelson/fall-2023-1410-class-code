public class Drink : MenuItem
{
  public string Size { get; }
  
  public Drink(string name, decimal price, string size)
    : base(name, price)
  {
    Size = size;
  }

  public override string ToString()
  {
    var outputString = base.ToString() + Environment.NewLine;
    outputString += $"  (Size: {Size})";
    return outputString;
  }

}
