public class Book
{
  public required int Id { get; set; }
  public required string Title { get; set; }
  public BookStatus Status { get; set; } = BookStatus.Available;
  public int DaysCheckedOut { get; set; }
  public string CheckedOutBy { get; set; }


  public static Book CreateCheckedOutBook()
  {
    var book = new Book() { 
      Id = 1000, 
      Title = "Biography", 
      Status = BookStatus.Borrowed 
    };
    return book;
  }

}