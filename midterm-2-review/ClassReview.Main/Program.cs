using System;
using System.ComponentModel;
using System.Text.Json;
using MyOwnNamespace;

var charizard = new Pokemon("Charizard", 10, 30);
var charizardAsJson = JsonSerializer.Serialize(charizard);
// Console.WriteLine(charizardAsJson);
var charizard2 = JsonSerializer.Deserialize<Pokemon>(charizardAsJson);


try 
{
  throw new MyOwnException("my message here");
}
catch (MyOwnException e)
{
  // Console.WriteLine(e.Message);
}
catch (Exception e)
{
  // Console.WriteLine(e.Message);
}

// Func
// Action

Func<int, string> myFunc = (int i) =>
{
  Console.WriteLine("here");
  return "";
};

myFunc(9);

var myList = new List<Pokemon>() { charizard, charizard with { Name = "Squirtle" }};

IEnumerable<string> namesOfPokemon = myList.Select((pokemon) => pokemon.Name);

var pokemonWhosNamesStartWithS = myList.Where((pokemon) => pokemon.Name.First() == 'S');

