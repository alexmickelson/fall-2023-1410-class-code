
Action<List<string>> printFunction = (List<string> tasks) =>
{
  for (int i = 0; i < tasks.Count; i++)
  {
    Console.WriteLine(tasks[i]);
  }
};

Action<List<string>> add = (List<string> tasks) =>
{
  Console.WriteLine("Enter task to add");
  string userInput = Console.ReadLine();
  tasks.Add(userInput);
};

Action<List<string>> remove = (List<string> tasks) =>
{
  Console.WriteLine("input the index of the task to remove");
  int userInput = int.Parse(Console.ReadLine());
  tasks.RemoveAt(userInput);
};


List<string> tasks = new List<string>();
tasks.Add("Do Homework");
tasks.Add("Laundry");

// add(tasks);
// printFunction(tasks);
// remove(tasks);
// printFunction(tasks);


// List<MenuItem> listOfMenuItems = new List<MenuItem>();
// listOfMenuItems.Add(new MenuItem("remove", remove));
// listOfMenuItems.Add(new MenuItem("add", add));
// listOfMenuItems.Add(new MenuItem("print", printFunction));
// listOfMenuItems.Add(new MenuItem("exit", (List<string> tasks) => {
//   Environment.Exit(1);
// }));

// bool finished = false;
// while (finished == false)
// {
//   for (int i = 0; i < listOfMenuItems.Count; i++)
//   {
//     Console.WriteLine(listOfMenuItems[i].Title);
//   }

//   int userInputIndex = int.Parse(Console.ReadLine());
//   listOfMenuItems[userInputIndex].DoTheThing(tasks);
// }


var menuDictionary = new Dictionary<string, Action<List<string>>>();
menuDictionary["remove"] = remove;
menuDictionary["add"] = add;
menuDictionary["print"] = printFunction;
menuDictionary["exit"] = (List<string> tasks) => {
  Environment.Exit(1);
};

bool finished = false;
while (finished == false)
{
  foreach(var item in menuDictionary)
  {
    Console.WriteLine(item.Key);
  }

  string userInputKey = Console.ReadLine();
  menuDictionary[userInputKey](tasks);
}