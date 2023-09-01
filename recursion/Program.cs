using System.Diagnostics;

Debug.Assert(ShiftChar('a', 'b') == 'b', $"could not shift a by b, got {ShiftChar('a', 'b')}");
Debug.Assert(ShiftChar('c', 'b') == 'd', $"could not shift c by b, got {ShiftChar('c', 'b')}");
Debug.Assert(ShiftChar('z', 'b') == 'a', $"could not shift z by b, got {ShiftChar('z', 'b')}");
Debug.Assert(ShiftChar('A', 'b') == 'b', $"could not shift A by b, got {ShiftChar('A', 'b')}");
Debug.Assert(ShiftChar('A', 'B') == 'b', $"could not shift A by B, got {ShiftChar('A', 'B')}");

char ShiftChar(char start, char distance)
{
  var isUpperCase = start >= 'A' && start <= 'Z';
  if(isUpperCase)
  {
    return ShiftChar((char)(start + 32), distance);
  }
  
  if (distance >= 'A' && distance <= 'Z')
  {
    return ShiftChar(start, (char)(distance + 32));
  }
  var alphabetStart = start - 'a';
  var alphabetDistance = distance - 'a';
  var shiftedCharacter = (char)((alphabetStart + alphabetDistance) % 26);
  return (char)(shiftedCharacter + 'a' );
}




var menuOptions = @"
press A to add an item, followed by the name of the item
press D to remove an item, followed by the name of item
";

// Console.WriteLine(menuOptions);

// var validUserInput = getValidUserInput();

// Console.WriteLine($"user input was {validUserInput}");


string getValidUserInput()
{
  Console.WriteLine("please input your option:");
  var rawInput = Console.ReadLine();
  var rawInputArray = rawInput.Split(" ");
  if(rawInputArray.Length != 2)
  {
    return getValidUserInput();
  }
  var rawAction = rawInputArray[0];
  var rawName = rawInputArray[1];

  if(rawName.Length < 3)
  {
    return getValidUserInput();
  }

  if(rawAction != "A" && rawAction != "D")
  {
    return getValidUserInput();
  }

  return rawInput;
}

//sequence contains no elements. stack exercise
int Sum(List<int> input)
{
  if(input.Count() == 1)
    return input[0];

  var lastNumber = input[^1];
  var everythingExceptTheLastNumber = input[0..^1];
  return lastNumber + Sum(everythingExceptTheLastNumber);
}

Debug.Assert(Sum(new List<int>() { 3 }) == 3, $"could not sum list of 1 got {Sum(new List<int>() { 3 })}");
Debug.Assert(Sum(new List<int>() { 1, 2, 3 }) == 6, $"could not sum list of 1, 2, 3 got {Sum(new List<int>() { 1, 2, 3 })}");

// experimenting with indexing
// var array = new int[] { 0, 1, 2, 3 };
// foreach(var n in array[0..^1])
// {
//   Console.WriteLine(n);
// }


// uint overflow = 2_147_483_647;
// Console.WriteLine(overflow);
// overflow += 1;
// Console.WriteLine(overflow);

// Factorial

int Factorial(int input)
{
  if(input == 1)
  {
    return 1;
  }
  return Factorial(input - 1) * input;
}

Debug.Assert(Factorial(1) == 1, "base case, factorial 1 should equal 1");
Debug.Assert(Factorial(2) == 2, $"factorial 2 should equal 2, was {Factorial(2)}");
Debug.Assert(Factorial(12) == 479001600, $"factorial 12 should equal 479001600, was {Factorial(12)}");