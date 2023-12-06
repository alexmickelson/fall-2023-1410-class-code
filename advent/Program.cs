
using System.Text;
using System.Text.Json;

var input = File.ReadAllLines("testInput.txt");

var listOfIntegers = input.Select((row) => {
    // var c = row[0];
    // char.IsDigit(c);
    var outputString = new StringBuilder();
    foreach(var c in row)
    {
        if(char.IsDigit(c))
        {
            outputString.Append(c);
        }
    }

    var firstNumber = outputString.ToString()[0];
    var lastNumber = outputString.ToString()[^1];

    var fullString = $"{firstNumber}{lastNumber}";
    return int.Parse(fullString);
});

Console.WriteLine(JsonSerializer.Serialize(listOfIntegers));
Console.WriteLine(listOfIntegers.Sum());