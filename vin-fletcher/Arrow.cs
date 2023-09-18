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
    return 2.3;
  }

  public double GetShaftLenght()
  {
    return ShaftLength;
  }
}