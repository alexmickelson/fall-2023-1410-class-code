
using System.Text.Json;

// var list = new List<MyThing>()
// {
//   new MyThing("one", "two"),
//   new MyThing("Three", "Four"),
// };

// string jsonSerializedList = JsonSerializer.Serialize(list);
// Console.WriteLine(jsonSerializedList);

// File.WriteAllText("thing.json", jsonSerializedList);

// var jsonSerializedList = File.ReadAllText("thing.json");
// var deserializedList = JsonSerializer
//   .Deserialize<List<MyThing>>
//   (jsonSerializedList);

// foreach(MyThing thing in deserializedList)
// {
//   Console.WriteLine(thing);
// }

// record MyThing(string ThatThing, string OtherThing);



// var myList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };


// var myEvenList = myList
//   .Select(i => i * 2)
//   .Where( n => n > 10)
//   .Where((n) =>
//   {
//     Console.WriteLine($"checking if {n} is greater than 14");
//     return n > 14;
//   });

// Console.WriteLine("here");

// foreach (var item in myEvenList)
// {
//   Console.WriteLine(item);
// }


var pokemonString = File.ReadAllText("pokemon.json");

var pokemonList = JsonSerializer.Deserialize<List<Pokemon>>(pokemonString);

var myPokemon = pokemonList
  .Where(pokemon => pokemon.Attack > 150)
  // .Where(pokemon => pokemon.Defense > 150)
  .Select(pokemon =>
  {
    var existingAttack = pokemon.Attack;
    var newAttack = existingAttack * 2;
    return pokemon with { Attack = newAttack };
  })
  .ToList();


// foreach (var pokemon in myPokemon)
// {
//   Console.WriteLine(pokemon);
// }

// store myPokemon in file

var output = JsonSerializer.Serialize(myPokemon);
var myPokemonFileName = "myFavoritePokemon.json";

if (!File.Exists(myPokemonFileName))
{
  Console.WriteLine("file does not exists");
  File.WriteAllText(myPokemonFileName, output);
}
else
{
  Console.WriteLine("file already exists");
}

var service = new StarWarsService();
var starWars = await service.GetStarWarsPerson();
Console.WriteLine(starWars);