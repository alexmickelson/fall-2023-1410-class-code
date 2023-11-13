var myPokemon = new Pokemon(
  Type2: "Fire",
  Total: 200,
  HP: 40,
  Id: "5",
  Attack: 50,
  Type1: "Water",
  SpecialDefense: 80,
  Defense: 30,
  SpecialAttack: 20,
  Name: "Ben",
  Speed: 60,
  Generation: "3"
);


int parsedNumber = 0;
var canParse = int.TryParse("32", out parsedNumber);

// if (canParse)
// {
//   Console.WriteLine(parsedNumber);
// }
// else
// {
//   Console.WriteLine($"could not parse {parsedNumber}");
// }


var myList = new List<int>() { 1, 2, 3, 4, 5 };


// var newList = myList
//   .Where(i => i > 1)
//   .Select(i => i * 3)
//   .PrintList()
//   .Where(i => i % 2 == 0);

// "my string".Print();

var maze = new Maze();

Console.WriteLine(maze);