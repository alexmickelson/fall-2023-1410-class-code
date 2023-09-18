public class Shelter
{
  private List<Pet> pets;

  public Shelter()
  {
    pets = new List<Pet>();
  }

  public void AddPet(string name, string species)
  {
    var newPet = new Pet(name, species);
    pets.Add(newPet);
  }

  public void AdoptPet(string petName)
  {
    foreach (var pet in pets)
    {
      if (pet.GetName() == petName)
      {
        pet.SetAdoptionStatus(AdoptionStatus.Adopted);
      }
    }
  }

  public void ListAvailablePets()
  {
    foreach (var pet in pets)
    {
      Console.WriteLine($"{pet.GetName()} - {pet.GetSpecies()} - {pet.GetAdoptionStatus()}");
    }
    Console.WriteLine();
  }
}