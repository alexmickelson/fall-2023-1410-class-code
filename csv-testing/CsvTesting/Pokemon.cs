using System.Text.Json.Serialization;
using CsvHelper.Configuration.Attributes;

public record Pokemon{
  [Name("#")]
  public int Id { get; init; }
  public string Name { get; init; }
  [Name("Type 1")]
  public string Type1 { get; init; }
  [Name("Type 2")]
  public string Type2 { get; init; }
  public int Total { get; init; }
  public int HP { get; init; }
  public int Attack { get; init; }
  public int Defense { get; init; }

  [Name("Sp. Atk")]
  public int SpecialAttack { get; init; }
  [Name("Sp. Def")]
  public int SpecialDefense { get; init; }
  public int Speed { get; init; }
  public string Generation { get; init; }
  public bool Legendary { get; init; }
}