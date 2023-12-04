
using System.Text.Json;
using Canvas.Assignments;

namespace Canvas;

public class CanvasService
{
    private string canvasToken { get; }
    public CanvasService()
    {
        string fileName = "canvasToken.txt";
        var currentDirectory = Directory.GetCurrentDirectory();

        if(currentDirectory.EndsWith("Console") || currentDirectory.EndsWith("Web"))
            canvasToken = File.ReadAllText("../" + fileName);
        else
            canvasToken = File.ReadAllText(fileName);
    }

    public async Task<List<CanvasAssignment>> GetCanvasAssignmentsAsync()
    {
        var client = new HttpClient();
        var url = "https://snow.instructure.com/api/v1/courses/871098/assignments";
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {canvasToken}");
        using HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();

        // Console.WriteLine(responseBody);
        File.WriteAllText("assignments.json", responseBody);

        var deserialized = JsonSerializer.Deserialize<List<CanvasAssignment>>(responseBody);
        return deserialized;
    }
}