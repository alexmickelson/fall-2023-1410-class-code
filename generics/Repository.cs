public record Repository<T> : IRepository<T>
{

  public List<T> privateList = new();
  public void Add(T item)
  {
    privateList.Add(item);
  }

  public void Remove(T item)
  {
    privateList.Remove(item);
  }
}
