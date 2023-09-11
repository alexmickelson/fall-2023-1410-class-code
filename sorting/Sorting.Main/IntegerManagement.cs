class IntegerManagement
{
  public List<int> CombineSortedArrays(List<int> list1, List<int> list2)
  {
    var combined = new List<int>() { };
    while (list1.Count + list2.Count != 0)
    {
      if (list1.Count == 0)
      {
        combined.Add(list2.First());
        list2.RemoveAt(0);
      }
      else if (list2.Count == 0)
      {
        combined.Add(list1.First());
        list1.RemoveAt(0);
      }
      else if (list1.First() < list2.First())
      {
        combined.Add(list1.First());
        list1.RemoveAt(0);
      }
      else
      {
        combined.Add(list2.First());
        list2.RemoveAt(0);
      }
    }
    return combined;
  }

  public List<int> SortViaMergeSort(List<int> input)
  {
    if (input.Count == 1)
      return input;
    var middle = input.Count / 2;
    var firstHalf = input[0..middle];
    var secondHalf = input[middle..^0];
    return CombineSortedArrays(
      SortViaMergeSort(firstHalf),
      SortViaMergeSort(secondHalf)
    );
  }
}