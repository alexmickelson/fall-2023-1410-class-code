// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.ReadLine();

// File.ReadAllText("./nubmers.txt");
// File.WriteAllText("./numbers-out.txt", "");

using System;
using System.Diagnostics;

static List<int> SelectionSort(List<int> input)
{
  for (int i = 0; i < input.Count(); i++)
  {


    var lastIndex = input.Count() - 1 - i;
    var largestIndex = 0;

    for (int j = 0; j < lastIndex; j++)
    {
      if (input[largestIndex] < input[j])
      {
        largestIndex = j;
      }
    }


    var lastValue = input[lastIndex];
    input[lastIndex] = input[largestIndex];
    input[largestIndex] = lastValue;

  }
  return input;
}

void TestSelectionSort()
{
  var numbers = new List<int>() { 2, 1 };
  var actualOutput = SelectionSort(numbers);
  var expectedOutput = new List<int>() { 1, 2 };
  for (int i = 0; i < actualOutput.Count(); i++)
  {
    var message = $"index: {i} not the same {actualOutput[i]} {expectedOutput[i]}";
    Debug.Assert(actualOutput[i] == expectedOutput[i], message);
  }
}

void TestSelectionSortWithMoreNumbers()
{
  var numbers = new List<int>() { 4, 3, 2, 1 };
  var actualOutput = SelectionSort(numbers);
  var expectedOutput = new List<int>() { 1, 2, 3, 4 };
  for (int i = 0; i < actualOutput.Count(); i++)
  {
    // var message = $"index: {i} not the same {actualOutput[i]} {expectedOutput[i]}";
    Debug.Assert(actualOutput[i] == expectedOutput[i], $"{actualOutput[0]} {actualOutput[1]} {actualOutput[2]} {actualOutput[3]}");
  }
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

TestSelectionSort();
TestSelectionSortWithMoreNumbers();

// foreach(var number in sortedList)
// {
//   Console.WriteLine(number);
// }