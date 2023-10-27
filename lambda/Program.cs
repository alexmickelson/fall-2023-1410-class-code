
using System.Text.Json;

var list = new List<MyThing>()
{
  new MyThing("one", "two"),
  new MyThing("Three", "Four"),
};

string jsonSerializedList = JsonSerializer.Serialize(list);
Console.WriteLine(jsonSerializedList);

record MyThing(string ThatThing, string OtherThing);