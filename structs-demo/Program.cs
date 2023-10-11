
var struct1 = new StructPoint() { Row = 1, Col = 1 };
var struct2 = new StructPoint() { Row = 1, Col = 1 };

var class1 = new ClassPoint() { Row = 1, Col = 1 };
var class2 = new ClassPoint() { Row = 1, Col = 1 };

// Console.WriteLine($"Struct Points Equal? {struct1.Equals(struct2)}");
// Console.WriteLine($"Class Points Equal by reference? {class1 == class2}");
// Console.WriteLine($"Class Points Equal by reference? {class1.Equals(class2)}");
// Console.WriteLine($"Class Points Equal by values? {class1.Row == class2.Row && class1.Col == class2.Col}");

var record1 = new RecordPoint(2, 1);
record1 = record1 with { Col = 3 };
var record2 = record1 with { Col = 3 };

Console.WriteLine($"Record Points Equal by reference? {record1 == record2}");
Console.WriteLine($"Record Points Equal by reference? {record1.Equals(record2)}");

var myList = new List<IClassPoint>()
{ struct1, struct2, class1, class2, record1, record2 };

foreach (var item in myList)
{
  Console.WriteLine(item);
}