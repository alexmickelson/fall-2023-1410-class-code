using Canvas;

var canvasService = new CanvasService();

var assignments = await canvasService.GetCanvasAssignmentsAsync();


foreach (var assignment in assignments)
{
    Console.WriteLine(assignment);
}