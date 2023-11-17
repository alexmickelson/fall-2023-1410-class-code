using System.Text;

public class ScoreTests
{
  [Test]
  public void TestScoreIncrements()
  {
    var map = new Map();
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Blank, Icon.Blank });

    Assert.AreEqual(5, map.Score);
  }
  [Test]
  public void TestScoreDoesNotIncrementIfDead()
  {
    var map = new Map();
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Wall, Icon.Wall });
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Wall, Icon.Wall });
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Wall, Icon.Wall });
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Wall, Icon.Wall });

    Assert.AreEqual(15, map.Score);
  }
  [Test]
  public void TestDeathCharacterIcon()
  {
    var expected = new StringBuilder("|🧱|🧱|🧱|🧱|" + Environment.NewLine);
    expected.Append("|🧱|🧱|🧱|🧱|" + Environment.NewLine);
    expected.Append("|🧱|🧱|🧱|🧱|" + Environment.NewLine);
    expected.Append("|🧱|💀|🧱|🧱|" + Environment.NewLine);
    var map = new Map();
    
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Wall, Icon.Wall });
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Wall, Icon.Wall });
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Wall, Icon.Wall });
    map.AddNewRow(new List<Icon>() { Icon.Wall, Icon.Wall, Icon.Wall, Icon.Wall });
    Assert.AreEqual(15, map.Score);
  }
}