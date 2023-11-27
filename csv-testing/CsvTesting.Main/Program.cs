

var listOfPokemon = PokemonService.ReadCsv();
foreach(var p in listOfPokemon)
{
    System.Console.WriteLine(p);
}