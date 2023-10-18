public record Box<T>
{
  public T Item { get; set; }

  public override string ToString()
  {
    var output = base.ToString();
    if(typeof(T) == typeof(Book))
      output += " it's a book!";
    return output;
  }
}