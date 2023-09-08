using System.Diagnostics;
using System.Diagnostics.Contracts;

List<int> CombineSortedArrays(List<int> list1, List<int> list2)
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

void RunTests()
{
  var condition1Results = CombineSortedArrays(new List<int>() { 1 }, new List<int>() { });
  var condition1ErrorMessage = $"Error on test for condition #1, sorted results are {string.Join(", ", condition1Results)}";
  Debug.Assert(
    Enumerable.SequenceEqual(
      condition1Results,
      new List<int>() { 1 }
    ),
    condition1ErrorMessage
  );


  var condition2Results = CombineSortedArrays(new List<int>() { }, new List<int>() { 1 });
  var condition2ErrorMessage = $"Error on test for condition #2, sorted results are {string.Join(", ", condition2Results)}";
  Debug.Assert(
    Enumerable.SequenceEqual(
      condition2Results,
      new List<int>() { 1 }
    ),
    condition2ErrorMessage
  );


  var condition3Results = CombineSortedArrays(new List<int>() { 1 }, new List<int>() { 2 });
  var condition3ErrorMessage = $"Error on test for condition #3, sorted results are {string.Join(", ", condition3Results)}";
  Debug.Assert(
    Enumerable.SequenceEqual(
      condition3Results,
      new List<int>() { 1, 2 }
    ),
    condition3ErrorMessage
  );

  var condition4Results = CombineSortedArrays(new List<int>() { 2 }, new List<int>() { 1 });
  var condition4ErrorMessage = $"Error on test for condition #4, sorted results are {string.Join(", ", condition4Results)}";
  Debug.Assert(
    Enumerable.SequenceEqual(
      condition4Results,
      new List<int>() { 1, 2 }
    ),
    condition4ErrorMessage
  );


  var repeatStep2Results = CombineSortedArrays(new List<int>() { 1, 3, 5 }, new List<int>() { -5, 3, 6, 7 });
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
      SortViaMergeSort(new List<int>() { 1 }),
      new List<int>() { 1 }
    ),
    $"error sorting base case, sorted results are {string.Join(", ", SortViaMergeSort(new List<int>() { 1 }))}"
  );

  // test small list
  Debug.Assert(
    Enumerable.SequenceEqual(
      SortViaMergeSort(new List<int>() { 1, 2 }),
      new List<int>() { 1, 2 }
    ),
    $"error sorting, sorted results are {string.Join(", ", SortViaMergeSort(new List<int>() { 1, 2 }))}"
  );

  // test larger list list
  Debug.Assert(
    Enumerable.SequenceEqual(
      SortViaMergeSort(new List<int>() { 6, 1, -5, 3, 5, 3, 7 }),
      new List<int>() { -5, 1, 3, 3, 5, 6, 7 }
    ),
    $"error sorting, sorted results are {string.Join(", ", SortViaMergeSort(new List<int>() { 1, 2 }))}"
  );
}



List<int> SortViaMergeSort(List<int> input)
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

RunTests();


void PrintMenu()
{
  Console.WriteLine(@"
what would you like to do:
1. add number to list
2. remove number from list by position
3. print current list
4. sort list
  ");
}

UserMenuSelection GetMenuOptionFromUser()
{
  var input = Console.ReadLine();
  if (input == "1")
  {
    var bobsSelection = new UserMenuSelection();

    bobsSelection.SelectedOption = MenuOptions.AddNumber;
    Console.WriteLine("You selected to add a number to the list");
    bobsSelection.OptionData = GetValidNumberFromUser();

    return bobsSelection;
  }
  if (input == "2")
  {
    Console.WriteLine("You Selected to remove a number. Enter the index of the number you would like to remove");

    var marysSelection = new UserMenuSelection
    {
      SelectedOption = MenuOptions.RemoveNumber,
      OptionData = GetValidNumberFromUser()
    };
    return marysSelection;
  }
  if (input == "3")
  {
    var timsSelection = new UserMenuSelection();
    timsSelection.SelectedOption = MenuOptions.PrintList;
    return timsSelection;
  }
  if (input == "4")
  {
    var timsSelection = new UserMenuSelection();
    timsSelection.SelectedOption = MenuOptions.SortList;
    return timsSelection;
  }

  Console.WriteLine($"Invalid input: {input}, please try again");
  return GetMenuOptionFromUser();
}

int GetValidNumberFromUser()
{
  Console.WriteLine("Please enter a valid number");
  var input = Console.ReadLine();
  try
  {
    return int.Parse(input);
  }
  catch
  {
    Console.WriteLine($"Invalid number {input}, try again");
    return GetValidNumberFromUser();
  }
}

List<int> HandleSelectedMenuOptions(UserMenuSelection menuSelection, List<int> myList)
{
  if (menuSelection.SelectedOption == MenuOptions.AddNumber)
  {
    myList.Add(menuSelection.OptionData);
    return myList;
  }
  else if (menuSelection.SelectedOption == MenuOptions.PrintList)
  {
    Console.WriteLine("\nHere is the list");
    Console.WriteLine(string.Join(", ", myList));
    return myList;
  }
  else if (menuSelection.SelectedOption == MenuOptions.RemoveNumber)
  {
    myList.RemoveAt(menuSelection.OptionData);
    return myList;
  }
  else if (menuSelection.SelectedOption == MenuOptions.SortList)
  {
    Console.WriteLine("Sorting the list");
    return SortViaMergeSort(myList);
  }
  return myList;
}

var myList = new List<int>();
while (true)
{
  PrintMenu();
  var option = GetMenuOptionFromUser();
  myList = HandleSelectedMenuOptions(option, myList);
}

enum MenuOptions
{
  AddNumber,
  PrintList,
  RemoveNumber,
  SortList
}

class UserMenuSelection
{
  public MenuOptions SelectedOption;
  public int OptionData;
}