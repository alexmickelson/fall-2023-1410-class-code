
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

    public async Task GetCanvasAssignmentsAsync()
    {
        var client = new HttpClient();
        using HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();

        Console.WriteLine(responseBody);
    }
}