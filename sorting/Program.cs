// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.ReadLine();

// File.ReadAllText("./nubmers.txt");
// File.WriteAllText("./numbers-out.txt", "");

static List<int> SelectionSort(List<int> input)
{
  for (int i = 0; i < input.Count(); i++)
  {
    var largestIndex = 0;
    if(input[largestIndex] < input[i])
    {
      largestIndex = i;
    }

    var lastIndex = input.Count() - 1 - i;

    var lastValue = input[lastIndex];
    input[lastIndex] = input[largestIndex];
    input[largestIndex] = lastValue;

  }
  return input;
}

var rawNumbers = File.ReadAllText("./numbers.txt");


var numbers = new List<int>();

var rawNumbersArray = rawNumbers.Split(' ');

foreach(var rawNumber in rawNumbersArray)
{
  try 
  {
    var parsedNumber = int.Parse(rawNumber);
    // if(parsedNumber < 1000)
    // {
    //   throw new Exception("number was less than 1000");
    // }
    numbers.Add(parsedNumber);
  }
  catch(Exception)
  {
    Console.WriteLine("something happened");
  }
}

numbers = new List<int>() { 4, 3, 2, 1 };

var sortedList = SelectionSort(numbers);

foreach(var number in sortedList)
{
  Console.WriteLine(number);
}