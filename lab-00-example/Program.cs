
var secret = "abcd";

static int NumberOfPositionsCorrect(int numberOfPositionsCorrect, char userInputLetter, char secretLetter)
{
  if (userInputLetter == secretLetter)
    numberOfPositionsCorrect += 1;
  return numberOfPositionsCorrect;
}

static int GetNumberOfLetterCorrect(string secret, string userInput, int numberOfLettersCorrect, int index) // parameters
{
  for (int j = 0; j < userInput.Length; j++)
  {
    if (userInput[index] == secret[j])
    {
      numberOfLettersCorrect += 1;
    }
  }

  return numberOfLettersCorrect;
}

static bool HandleUserGuess(string secret, ref int guessCount)
{
  bool isDone;
  guessCount += 1;
  Console.WriteLine($"Guess #{guessCount}, input a 4 letter, lowercase value:");
  var userInput = Console.ReadLine();

  var numberOfPositionsCorrect = 0;
  var numberOfLettersCorrect = 0;

  for (var i = 0; i < secret.Length; i++)
  {
    var userInputLetter = userInput[i];
    var secretLetter = secret[i];

    numberOfPositionsCorrect = NumberOfPositionsCorrect(numberOfPositionsCorrect, userInputLetter, secretLetter);
    numberOfLettersCorrect = GetNumberOfLetterCorrect(secret, userInput, numberOfLettersCorrect, i); //arguments
  }

  Console.WriteLine($"You got {numberOfLettersCorrect} letters correct and {numberOfPositionsCorrect} positions correct");

  isDone = numberOfPositionsCorrect == secret.Length;
  return isDone;
}

var isDone = false;

Console.WriteLine("Welcome to my guessing game");

var guessCount = 0;
while (!isDone)
{
  isDone = HandleUserGuess(secret, ref guessCount);
}

Console.WriteLine($"You Guessed It! it took you {guessCount} tries");
