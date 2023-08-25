// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.ReadLine();

// File.ReadAllText("./nubmers.txt");
// File.WriteAllText("./numbers-out.txt", "");

var rawNumbers = File.ReadAllText("./numbers.txt");


var numbers = new List<int>();

var rawNumbersArray = rawNumbers.Split(' ');

foreach(var rawNumber in rawNumbersArray)
{
  numbers.Add(int.Parse(rawNumber));
  // double.Parse
  // char.Parse();

}

foreach(var number in numbers)
{
  Console.WriteLine(number);
}