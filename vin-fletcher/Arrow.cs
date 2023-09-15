public class Arrow
{
  public double ShaftLength;
  public ArrowHead Point;
  public Fletching FletchingMaterial;

  public Arrow(ArrowHead point, Fletching fletching, double length)
  {
    Point = point;
    FletchingMaterial = fletching;
    length = length;
  }
}