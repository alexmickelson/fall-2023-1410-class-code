public class Menu: List<IMenuItem>
{
  public override string ToString()
  {
    string overrideToString = "";

    overrideToString += "Welcome to Our Restaurant!\n";
    overrideToString += "--------------------------\n";
    overrideToString += "Menu:\n";
    foreach (var item in this)
    {
      overrideToString += item + Environment.NewLine;
    }
    return overrideToString;
  }
}