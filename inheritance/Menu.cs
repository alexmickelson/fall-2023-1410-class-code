public class Menu
{
  private List<MenuItem> menuItems { get; }

  public Menu()
  {
    menuItems = new List<MenuItem>{};
  }

  public void Add(MenuItem newItem)
  {
    menuItems.Add(newItem);
  }

  public void Display()
  {
    Console.WriteLine("Welcome to Our Restaurant!");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Menu:");
    foreach (var item in menuItems)
    {
      item.Display();
    }
  }

}