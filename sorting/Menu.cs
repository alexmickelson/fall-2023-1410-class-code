class Menu
{
  public void PrintMenu()
  {
    Console.WriteLine(@"
what would you like to do:
1. add number to list
2. remove number from list by position
3. print current list
4. sort list
");
  }


  public UserMenuSelection GetMenuOptionFromUser()
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
  public int GetValidNumberFromUser()
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

  public List<int> HandleSelectedMenuOptions(UserMenuSelection menuSelection, List<int> myList)
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
      var managingInts = new IntegerManagement();
      return managingInts.SortViaMergeSort(myList);
    }
    return myList;
  }
}