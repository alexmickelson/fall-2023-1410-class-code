PokemonCard charizardCard = new PokemonCard("Charizard", 120, "Fire");

try
{
  charizardCard.SaveToFile("charizard_card.txt");
}
catch (FileAlreadyExistsException exception)
{
  Console.WriteLine(exception.FilePath);
  Console.WriteLine(exception.Message);
  Environment.Exit(1);
}
catch(FormatException exception)
{
  Console.WriteLine(exception.Message);
  Environment.Exit(1);
}

PokemonCard loadedCard = PokemonCard.LoadFromFile("charizard_card.txt");

if (loadedCard != null)
{
  Console.WriteLine("Loaded Pokemon Card:");
  Console.WriteLine(loadedCard);
}
else
{
  Console.WriteLine("could not load pokemon card");
}
