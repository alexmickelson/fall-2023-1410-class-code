using System.Collections;

public class LibraryEnumerator<T> : IEnumerator<T>
{
  private int position = -1;
  private readonly List<Book> books;

  public LibraryEnumerator(List<Book> books)
  {
    this.books = books;
  }
  public object Current { get => books[position]; }

  T IEnumerator<T>.Current => throw new NotImplementedException();

  public bool MoveNext()
  {
    if(position >= books.Count - 1)
    {
      return false;
    }
    position += 1;
    return true;
  }
  public void Reset()
  {
    position = -1;
  }

  public void Dispose()
  {
    throw new NotImplementedException();
  }
}