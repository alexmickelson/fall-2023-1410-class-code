public class MenuItem
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
}
