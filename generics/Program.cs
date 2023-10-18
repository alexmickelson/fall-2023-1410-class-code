var shelf = new BookShelf<Book>();

shelf.Add(new Book("The Hobbit"));
shelf.Add(new Book("Mistborn"));

Console.WriteLine(shelf);


var pictureShelf = new BookShelf<Picture>();

pictureShelf.Add(new Picture("The Hobbit"));
pictureShelf.Add(new Picture("Mistborn"));

Console.WriteLine(pictureShelf);




var pictureBox = new Box<Picture>();
var bookBox = new Box<Book>();

pictureBox.Item = new Picture("The Hobbit");
bookBox.Item = new Book("The Hobbit");
Console.WriteLine(pictureBox);
Console.WriteLine(bookBox);
Console.WriteLine();




var bigBox = new BigBox<Picture, int>(pictureBox.Item, 5);

Console.WriteLine(bigBox);


var repo = new Repository<int>();

repo.Add(1);
Console.WriteLine(repo);