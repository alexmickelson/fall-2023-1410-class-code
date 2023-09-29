public class MenuItem
{
  private string name;

  public string Name { 
    get => name; 
    set {

      // old value: name
      // new value: value
      // Console.WriteLine(this.DisplayText);
      // DisplayText = DisplayText.Replace(name, value);
      DisplayText.Replace(name, value);
      // name = value;

    }
  }
  public decimal Price { get; set; }
  public string DisplayText { get; set; }
  public MenuItem() { }
  public MenuItem(string name, decimal price, string displayText)
  {
    Name = name;
    Price = price;
    DisplayText = displayText;
  }
  public MenuItem(string name, decimal price)
  {
    Name = name;
    Price = price;
    DisplayText = $"- {name}: ${price}";
  }
  public void Display()
  {
    Console.WriteLine(DisplayText);
  }
}
