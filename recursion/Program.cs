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

Console.WriteLine(menuOptions);

var validUserInput = getValidUserInput();

Console.WriteLine($"user input was {validUserInput}");

// do thing that user asked


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
// Debug.Assert(Sum(new List<int>() { 1, 2, 3 }) == 6, $"could not sum list of 1, 2, 3 got {Sum(new List<int>() { 1, 2, 3 })}");
// int Sum(List<int> input)
// {
//   var last = input.Last();
//   input.RemoveAt(input.Count - 1);
//   return last + Sum(input);
// }