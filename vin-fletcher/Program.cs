﻿
using System.Runtime.CompilerServices;

var myArrow = new Arrow(ArrowHead.Steel, Fletching.Plastic, 65.3);

Console.WriteLine(
  $"My arrow: {myArrow.Point}, {myArrow.FletchingMaterial} {myArrow.GetShaftLenght()} ${myArrow.GetCost()}"
);
