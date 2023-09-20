using System.Buffers;

public class Arrow
{
  public ArrowHead Point { get; set; }
  public Fletching FletchingMaterial { get; }

  private int _shaftLengthInMillimeters;
  public double ShaftLength
  {
    get => _shaftLengthInMillimeters / 10.0;
    set
    {
      if (value < _shaftLengthInMillimeters)
      {
        _shaftLengthInMillimeters = (int)(value * 10);
      }
    }
  }

  public Arrow(ArrowHead point, Fletching fletching, double length)
  {
    Point = point;
    FletchingMaterial = fletching;
    _shaftLengthInMillimeters = (int)(length * 10);
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

    if (FletchingMaterial == Fletching.Plastic)
      cost += 10;
    if (FletchingMaterial == Fletching.TurkeyFeathers)
      cost += 5;
    if (FletchingMaterial == Fletching.GooseFeathers)
      cost += 3;

    cost += .05 * ShaftLength;

    return cost;
  }

}