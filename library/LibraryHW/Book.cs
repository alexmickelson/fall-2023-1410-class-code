public class Book
{
  public required int Id { get; set; }
  public required string Title { get; set; }
  public int DaysCheckedOut { get; set; }
  public string? CheckedOutBy { get; set; }


  public static Book CreateCheckedOutBook()
  {
    var book = new Book() { 
      Id = 1000, 
      Title = "Biography", 
    };
    return book;
  }

}