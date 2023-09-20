public class Arrow
{
  private double ShaftLength;
  public ArrowHead Point;
  public Fletching FletchingMaterial;

  public Arrow(ArrowHead point, Fletching fletching, double length)
  {
    Point = point;
    FletchingMaterial = fletching;
    ShaftLength = length;
  }

  public double GetCost()
  {
    double cost = 0;

    if (Point == ArrowHead.Steel)
      cost += 10;
    if (Point == ArrowHead.Wood)
      cost += 3;
    if (Point == ArrowHead.Obsidian)
      cost += 5;

    if(FletchingMaterial == Fletching.Plastic)
      cost += 10;
    if(FletchingMaterial == Fletching.TurkeyFeathers)
      cost += 5;
    if(FletchingMaterial == Fletching.GooseFeathers)
      cost += 3;

    cost += .05 * ShaftLength;

    return cost;
  }

  public double GetShaftLenght()
  {
    return ShaftLength;
  }
}