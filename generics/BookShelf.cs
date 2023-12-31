public class BookShelf<T>
{
  private List<T> books { get; } = new();
  public void Add(T input)
  {
    books.Add(input);
  }

  public override string ToString()
  {
    var lineWidth = 30;
    var horizontalDashes = new string('-', lineWidth);
    string output = horizontalDashes + Environment.NewLine;

    foreach(var book in books)
    {
      output += centerText(book.ToString(), lineWidth) + Environment.NewLine;
      output += horizontalDashes + Environment.NewLine;
    }
    return output;
  }

  private static string centerText(string input, int totalWidth)
  {
    if (input.Length >= totalWidth)
    {
      return input;
    }

    int paddingSize = (totalWidth - input.Length) / 2;
    int leftPadding = paddingSize;
    int rightPadding = totalWidth - input.Length - leftPadding;

    return new string(' ', leftPadding) + input + new string(' ', rightPadding);
  }
}