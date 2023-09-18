using System.Diagnostics;

public class Testing
{
  public void RunTests()
  {
    var intManager = new IntegerManagement();
    var condition1Results = intManager.CombineSortedArrays(new List<int>() { 1 }, new List<int>() { });
    var condition1ErrorMessage = $"Error on test for condition #1, sorted results are {string.Join(", ", condition1Results)}";
    Debug.Assert(
      Enumerable.SequenceEqual(
        condition1Results,
        new List<int>() { 1 }
      ),
      condition1ErrorMessage
    );

    var condition2Results = intManager.CombineSortedArrays(new List<int>() { }, new List<int>() { 1 });
    var condition2ErrorMessage = $"Error on test for condition #2, sorted results are {string.Join(", ", condition2Results)}";
    Debug.Assert(
      Enumerable.SequenceEqual(
        condition2Results,
        new List<int>() { 1 }
      ),
      condition2ErrorMessage
    );


    var condition3Results = intManager.CombineSortedArrays(new List<int>() { 1 }, new List<int>() { 2 });
    var condition3ErrorMessage = $"Error on test for condition #3, sorted results are {string.Join(", ", condition3Results)}";
    Debug.Assert(
      Enumerable.SequenceEqual(
        condition3Results,
        new List<int>() { 1, 2 }
      ),
      condition3ErrorMessage
    );

    var condition4Results = intManager.CombineSortedArrays(new List<int>() { 2 }, new List<int>() { 1 });
    var condition4ErrorMessage = $"Error on test for condition #4, sorted results are {string.Join(", ", condition4Results)}";
    Debug.Assert(
      Enumerable.SequenceEqual(
        condition4Results,
        new List<int>() { 1, 2 }
      ),
      condition4ErrorMessage
    );


    var repeatStep2Results = intManager.CombineSortedArrays(new List<int>() { 1, 3, 5 }, new List<int>() { -5, 3, 6, 7 });
    var repeatStep2ErrorMessage = $"Error on test for repeating step #2, sorted results are {string.Join(", ", repeatStep2Results)}";
    Debug.Assert(
      Enumerable.SequenceEqual(
        repeatStep2Results,
        new List<int>() { -5, 1, 3, 3, 5, 6, 7 }
      ),
      repeatStep2ErrorMessage
    );

    // Test Base Case
    Debug.Assert(
      Enumerable.SequenceEqual(
        intManager.SortViaMergeSort(new List<int>() { 1 }),
        new List<int>() { 1 }
      ),
      $"error sorting base case, sorted results are {string.Join(", ", intManager.SortViaMergeSort(new List<int>() { 1 }))}"
    );

    // test small list
    Debug.Assert(
      Enumerable.SequenceEqual(
        intManager.SortViaMergeSort(new List<int>() { 1, 2 }),
        new List<int>() { 1, 2 }
      ),
      $"error sorting, sorted results are {string.Join(", ", intManager.SortViaMergeSort(new List<int>() { 1, 2 }))}"
    );

    // test larger list list
    Debug.Assert(
      Enumerable.SequenceEqual(
        intManager.SortViaMergeSort(new List<int>() { 6, 1, -5, 3, 5, 3, 7 }),
        new List<int>() { -5, 1, 3, 3, 5, 6, 7 }
      ),
      $"error sorting, sorted results are {string.Join(", ", intManager.SortViaMergeSort(new List<int>() { 1, 2 }))}"
    );
  }

}