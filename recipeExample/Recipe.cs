using System.Text;

public record Recipe
{
  public required string Title { get; set; }
  public required List<string> Ingredients { get; set; }
  public required List<string> Instructions { get; set; }
  public override string ToString()
  {
    var recipeString = new StringBuilder();
    recipeString.Append($"Recipe: {Title}"+ Environment.NewLine);
    recipeString.Append("Ingredients:"+ Environment.NewLine);
    foreach (string ingredient in Ingredients)
    {
      recipeString.Append("- " + ingredient+ Environment.NewLine);
    }
    recipeString.Append("Instructions:"+ Environment.NewLine);
    foreach (string step in Instructions)
    {
      recipeString.Append(step+ Environment.NewLine);
    }

    return recipeString.ToString();
  }
}
