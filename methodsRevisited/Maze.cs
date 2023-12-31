using System.Text;

public class Maze
{
  public Maze()
  {
    var stringMaze =
    new StringBuilder("      ######################################################" + Environment.NewLine);
    stringMaze.Append("#     #     #       #        ##                 # ### # ####" + Environment.NewLine);
    stringMaze.Append("# ##   ## # ### ###### ######## # #     # # #         #    #" + Environment.NewLine);
    stringMaze.Append("# # #  #  # # # #      #     ## # #     # # # #    #########" + Environment.NewLine);
    stringMaze.Append("### #  ## ### ### ###### ### ## #     # # # # #            #" + Environment.NewLine);
    stringMaze.Append("#   #         # #      #   #        ### ### # ###  #########" + Environment.NewLine);
    stringMaze.Append("## ### ### ### # # ####### # ##     #   #   #   #          #" + Environment.NewLine);
    stringMaze.Append("# #     #     # #   #   # #  ######## # # ##### ###     ## #" + Environment.NewLine);
    stringMaze.Append("# ####  # ##### ##    # # #           # #       #   #    # #" + Environment.NewLine);
    stringMaze.Append("#       #   #   #     # #    ## ####### ####### ### #      #" + Environment.NewLine);
    stringMaze.Append("######  ###### # # #####        #       #     #     # #    #" + Environment.NewLine);
    stringMaze.Append("#           # # #            ## # ##### # ### ####### #    #" + Environment.NewLine);
    stringMaze.Append("# ### ####          # #####   # # #   # #   # #     # #    #" + Environment.NewLine);
    stringMaze.Append("# # #     # # #   # #   #    ## # # ### ### # # # ### #    #" + Environment.NewLine);
    stringMaze.Append("#######################################################     ");

    grid = new();
    foreach (var row in stringMaze.ToString().Split(Environment.NewLine))
    {
      var gridRow = new List<MazeSprite>();
      foreach (var cell in row)
      {
        if (cell == '#')
          gridRow.Add(MazeSprite.Wall);
        else
          gridRow.Add(MazeSprite.Blank);
      }
      grid.Add(gridRow);
    }

    grid[0][0] = MazeSprite.Player;
    
    // Console.WriteLine("grid complete");
  }

  private List<List<MazeSprite>> grid { get; }
  public override string ToString()
  {
    StringBuilder output = new StringBuilder();
    foreach (var row in grid)
    {
      output.Append(row);
    }

    return output;
  }
}