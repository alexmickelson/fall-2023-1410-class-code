using System.Reflection.Metadata.Ecma335;

public class Library
{
  public List<Book> Books { get; internal set; } = new List<Book>()
  {
    new Book() { Id = 1, Title = "To Kill a Mockingbird" },
    new Book() { Id = 2, Title = "Clean Code" },
    new Book() { Id = 3, Title = "The Phoenix Project"  },
    new Book() { Id = 4, Title = "Csharp Players Guide" },
  };

  public void AddBook(string title)
  {
    int newId = GenerateNextId(this);
    var newBook = new Book() { Id = newId, Title = title };

    Books.Add(newBook);
  }

  public static int GenerateNextId(Library currentLibrary)
  {
    return currentLibrary.Books[currentLibrary.Books.Count - 1].Id + 1;
  }

  public string GetAsString()
  {
    var output = string.Empty;

    foreach (var book in Books)
    {
      output += $"{book.Id} - {book.Title}";
      if (book.CheckedOutBy != null)
      {
        output += $" - has been checked out by {book.CheckedOutBy} for {book.DaysCheckedOut} days";
      }
      output += Environment.NewLine;
    }
    return output;
  }

  public void CheckOut(int bookId, string byUser)
  {
    foreach (var book in Books)
    {
      if (book.Id == bookId)
      {
        book.CheckedOutBy = byUser;
        book.DaysCheckedOut = 0;
      }
    }
  }

  public static void RunEndOfDay(Library ourLibrary)
  {
    foreach (var book in ourLibrary.Books)
    {
      if (book.CheckedOutBy != null)
      {
        book.DaysCheckedOut += 1;
      }
    }
  }

  private static double lateFeePerDay = 0.2;
  private static int overdueDays = 2;
  public static double CalculateLateFee(Book book)
  {

    if(book.DaysCheckedOut > overdueDays)
    {
      return lateFeePerDay * (book.DaysCheckedOut - overdueDays);
    }
    return 0.0;
  }

}

// static method for late fee

// get book genre
