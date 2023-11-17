public class Menu
{
  private ScoresManager Scores = new ScoresManager();
  public void PrintMenu()
  {
    Console.WriteLine("Welcome to the Endless Runner Menu. Please select an option:");
    Console.WriteLine("1: Play Game");
    Console.WriteLine("2: Show Scores");
  }

  public int GetMenuOptionFromUser()
  {
    var input = int.Parse(Console.ReadLine());
    return input;
  }

  public void HandleMenuOption(int selectedOption)
  {
    if (selectedOption == 1)
      playGame();
    if (selectedOption == 2)
      ShowScores();

  }

  private void playGame()
  {
    var map = new Map();
    var displayThread = new Thread(() =>
    {
      while (!map.HasDied)
      {
        Console.Clear();
        Console.WriteLine(map);

        Thread.Sleep(1000);
        var newRow = map.GenerateNewRow();
        map.AddNewRow(newRow);
      }

      Scores.AddScore(map.Score);
      Console.Clear();
      Console.WriteLine(map);
      Thread.Sleep(1000);
      Console.Clear();
      Console.WriteLine($"Game Over, your score was: {map.Score}");
      Thread.Sleep(1000);
      Console.Clear();
    });

    var controlThread = new Thread(() =>
    {
      while (!map.HasDied)
      {
        if (Console.KeyAvailable)
        {
          var input = Console.ReadKey(true);
          if (input.Key == ConsoleKey.A)
          {
            map.GoLeft = true;
            map.GoRight = false;
          }
          else if (input.Key == ConsoleKey.D)
          {
            map.GoLeft = false;
            map.GoRight = true;
          }
        }
      }
    });

    displayThread.Start();
    controlThread.Start();

    displayThread.Join();
    controlThread.Interrupt();
  }

  public void ShowScores()
  {
    Console.Clear();
    Console.WriteLine("Scores");
    foreach (var score in Scores.GetScores())
    {
      Console.WriteLine(score);
    }
  }
}
