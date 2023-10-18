using System.Collections;

public class EnumerableLibrary : IEnumerable
{
  private List<Book> books = new List<Book>()
  {
    new Book() { Id = 1, Title = "To Kill a Mockingbird" },
    new Book() { Id = 2, Title = "Clean Code" },
    new Book() { Id = 3, Title = "The Phoenix Project"  },
    new Book() { Id = 4, Title = "Csharp Players Guide" },
  };

  public IEnumerator GetEnumerator()
  {
    return new LibraryEnumerator(books);
  }
}
