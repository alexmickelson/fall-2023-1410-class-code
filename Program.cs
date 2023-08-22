
var secret = "abcd";
var isDone = false;

Console.WriteLine("Welcome to my guessing game");

var guessCount = 0;
while (!isDone)
{
  guessCount += 1;
  Console.WriteLine($"Guess #{guessCount}, input a 4 letter, lowercase value:");
  var userInput = Console.ReadLine();

  var numberOfPositionsCorrect = 0;
  var numberOfLettersCorrect = 0;

  for (var i = 0; i < secret.Length; i++)
  {
    var userInputLetter = userInput[i];
    var secretLetter = secret[i];

    if (userInputLetter == secretLetter)
      numberOfPositionsCorrect += 1;

    if (secret.Contains(userInputLetter))
      numberOfLettersCorrect += 1;
  }

  Console.WriteLine($"You got {numberOfLettersCorrect} letters correct and {numberOfPositionsCorrect} positions correct");

  isDone = numberOfPositionsCorrect == secret.Length;
}

Console.WriteLine($"You Guessed It! it took you {guessCount} tries");