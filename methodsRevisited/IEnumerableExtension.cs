public static class IEnumerableExtension
{
  public static IEnumerable<T> PrintList<T>(this IEnumerable<T> originalList)
  {
    foreach(var item in originalList)
    {
      Console.WriteLine(item);
    }
    return originalList;
  }

  public static void Print(this string thingToPrint)
  {
    Console.WriteLine(thingToPrint);
  }
}