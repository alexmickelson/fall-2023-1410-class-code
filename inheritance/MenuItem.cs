public interface IMenuItem
{
  string Name { get; set; }
  decimal Price { get; set; }
  string ToString();
}

public class MenuItem: IMenuItem
{
  public string Name { get; set; }
  public decimal Price { get; set; }

  public MenuItem() { }
  public MenuItem(string name, decimal price)
  {
    Name = name;
    Price = price;
  }
  public virtual void Display()
  {
    Console.WriteLine($"- {Name}: ${Price}");
  }

  public override string ToString()
  {
    return $"- {Name}: ${Price}";
  }
}
