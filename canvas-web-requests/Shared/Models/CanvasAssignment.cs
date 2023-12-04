using System.Text.Json.Serialization;

namespace Canvas.Assignments;

public record CanvasAssignment
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("html_url")]
    public string HtmlUrl { get; init; }

    [JsonPropertyName("points_possible")]
    public double PointsPossible { get; init; }

    [JsonPropertyName("due_date")]
    public DateTime DueAt { get; init; }
}

