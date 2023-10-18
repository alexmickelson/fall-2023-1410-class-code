
// var ourLibrary = new Library();
// Console.WriteLine(ourLibrary.GetAsString());

// ourLibrary.AddBook("Unicorn Project");
// ourLibrary.AddBook("Harry Potter");

// Console.WriteLine($"the next id will be: {Library.GenerateNextId(ourLibrary)}");

// ourLibrary.CheckOut(1, "maya");
// Library.RunEndOfDay(ourLibrary);
// Library.RunEndOfDay(ourLibrary);
// Library.RunEndOfDay(ourLibrary);
// Library.RunEndOfDay(ourLibrary);
// Console.WriteLine(ourLibrary.GetAsString());

// Console.WriteLine(Library.CalculateLateFee(ourLibrary.Books[0]));

var enumerableLibrary = new EnumerableLibrary();

foreach (var book in enumerableLibrary)
{
  Console.WriteLine(book);
}


// NULL testing code
// Book? myBook = null;
// a bunch of other code
// myBook = new Book() { Id = 888, Title = "Title" };


// // null conditial 
// Console.WriteLine($"title: {myBook?.Title}");

// // null coalescing
// // Book notNullBook = myBook ?? throw new Exception("myBook is null");
// Book notNullBook = myBook ?? new Book() { Id = 888, Title = "Title" };

// Book otherNotNullBook = myBook;