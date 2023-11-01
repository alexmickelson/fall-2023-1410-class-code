public record Product(
  int id,
  string title,
  double price,
  string description,
  string category,
  string image,
  Rating rating
);

public record Rating
{
  public double rate { get; init; }
  public int count { get; init; }
}