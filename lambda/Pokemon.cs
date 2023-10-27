using System.Text.Json.Serialization;

public record Pokemon
{
  [JsonPropertyName("Id")]
  public string Id { get; init; }

  [JsonPropertyName("Name")]
  public string Name { get; init; }

  [JsonPropertyName("Type 1")]
  public string Type1 { get; init; }

  [JsonPropertyName("Type 2")]
  public string Type2 { get; init; }

  [JsonPropertyName("Total")]
  public string Total { get; init; }

  [JsonPropertyName("HP")]
  public string HP { get; init; }

  [JsonPropertyName("Attack")]
  public string Attack { get; init; }

  [JsonPropertyName("Defense")]
  public string Defense { get; init; }

  [JsonPropertyName("Sp. Atk")]
  public string SpAtk { get; init; }

  [JsonPropertyName("Sp. Def")]
  public string SpDef { get; init; }

  [JsonPropertyName("Speed")]
  public string Speed { get; init; }

  [JsonPropertyName("Generation")]
  public string Generation { get; init; }

  [JsonPropertyName("Legendary")]
  public string Legendary { get; init; }
}