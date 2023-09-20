
using System.Runtime.CompilerServices;

var myArrow = new Arrow(
  ArrowHead.Steel, 
  Fletching.Plastic, 
  65.300000005
);

Console.WriteLine(
  $"My arrow: "+
  myArrow.Point + ", " + 
  myArrow.FletchingMaterial + " "  +
  myArrow.ShaftLength + " $" + 
  myArrow.GetCost()
);

myArrow.ShaftLength = 61.8;

Console.WriteLine(
  $"My arrow: " +
  myArrow.Point + ", " +
  myArrow.FletchingMaterial + " " +
  myArrow.ShaftLength + " $" +
  myArrow.GetCost()
);

