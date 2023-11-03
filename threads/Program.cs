
var xPosition = 1;
var yPosition = 1;
var width = 20;
var height = 10;

var printThread = new Thread(() =>
{
  while (true)
  {
    printGame();
    Thread.Sleep(1000);
  }
});


var userInputThread = new Thread(() =>
{
  while (true)
  {
    getAndExecuteMovement();
  }
});

printThread.Start();
userInputThread.Start();



void printGame()
{
  Console.Clear();
  for (int y = 0; y < height; y++)
  {
    for (int x = 0; x < width; x++)
    {
      if (x == xPosition && y == yPosition)
        Console.Write("🧔");
      else
        Console.Write("--");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

void getAndExecuteMovement()
{
  ConsoleKeyInfo userInputKey = Console.ReadKey(true);
  if (userInputKey.Key == ConsoleKey.A)
    xPosition--;
  else if (userInputKey.Key == ConsoleKey.D)
    xPosition++;
  else if (userInputKey.Key == ConsoleKey.W)
    yPosition--;
  else if (userInputKey.Key == ConsoleKey.S)
    yPosition++;
}