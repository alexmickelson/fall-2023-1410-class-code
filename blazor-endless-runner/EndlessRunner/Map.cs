using System.Text;

public class Map
{
  private List<List<Icon>> map { get; set; }
  public bool HasDied { get; private set; } = false;
  public bool GoLeft { get; set; }
  public bool GoRight { get; set; }

  public int Score { get; private set; }

  public Map()
  {

    map = new List<List<Icon>>()
    {
      new() { Icon.Blank, Icon.Blank, Icon.Blank, Icon.Blank },
      new() { Icon.Blank, Icon.Blank, Icon.Blank, Icon.Blank },
      new() { Icon.Blank, Icon.Blank, Icon.Blank, Icon.Blank },
      new() { Icon.Blank, Icon.Character, Icon.Blank, Icon.Blank },
    };
  }

  public override string ToString()
  {
    var builder = new StringBuilder();
    foreach (var row in map)
    {
      builder.Append("|");
      foreach (var cell in row)
      {
        if (cell == Icon.Blank)
          builder.Append("  ");
        else if (cell == Icon.Wall)
          builder.Append("🧱");
        else if (cell == Icon.Character)
        {
          if (HasDied)
            builder.Append("💀");
          else
            builder.Append("😀");
        }

        builder.Append("|");
      }
      builder.Append(Environment.NewLine);
    }
    return builder.ToString();
  }

  public void AddNewRow(List<Icon> rowToAdd)
  {
    var lastRow = map[map.Count - 1];
    var secondToLastRow = map[map.Count - 2];
    var indexOfCharacter = lastRow.IndexOf(Icon.Character);

    if (GoRight && indexOfCharacter < lastRow.Count - 1)
      indexOfCharacter += 1;
    if (GoLeft && indexOfCharacter > 0)
      indexOfCharacter -= 1;

    if (secondToLastRow[indexOfCharacter] == Icon.Wall)
      HasDied = true;

    secondToLastRow[indexOfCharacter] = Icon.Character;
    map = map.Slice(0, map.Count - 1).Prepend(rowToAdd).ToList();


    if (!HasDied)
      Score += 5;
    GoRight = false;
    GoLeft = false;
  }

  public List<Icon> GenerateNewRow()
  {
    var random = new Random();
    var wallPosition = random.Next(3);

    var blankRow = new List<Icon>() { Icon.Blank, Icon.Blank, Icon.Blank, Icon.Blank };
    blankRow[wallPosition] = Icon.Wall;
    return blankRow;
  }
}