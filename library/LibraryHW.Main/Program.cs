
var ourLibrary = new Library();
Console.WriteLine(ourLibrary.GetAsString());

ourLibrary.AddBook("Unicorn Project");

Console.WriteLine($"the next id will be: {Library.GenerateNextId(ourLibrary)}");

ourLibrary.CheckOut(1, "maya");
Library.RunEndOfDay(ourLibrary);
Library.RunEndOfDay(ourLibrary);
Library.RunEndOfDay(ourLibrary);
Library.RunEndOfDay(ourLibrary);
Console.WriteLine(ourLibrary.GetAsString());

Console.WriteLine(Library.CalculateLateFee(ourLibrary.Books[0]));


Book myBook = Book.CreateCheckedOutBook();


