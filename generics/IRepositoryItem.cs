public interface IRepositoryItem<T>
{
  T item { get; init; }
  T Add(int input);
}