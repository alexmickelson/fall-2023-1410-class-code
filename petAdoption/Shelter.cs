public class Shelter
{
  public List<Pet> Pets;

  public Shelter()
  {
    Pets = new List<Pet>();
  }
  public void AddPet(string name, string species)
  {
    var newPet = new Pet(name, species);
    Pets.Add(newPet);
  }

  public void AdoptPet(string petName)
  {
    foreach (var pet in Pets)
    {
      if (pet.Name == petName)
      {
        pet.Status = AdoptionStatus.Adopted;
      }
    }
  }

  public void ListAvailablePets()
  {
    foreach (var pet in Pets)
    {
      Console.WriteLine($"{pet.Name} - {pet.Species} - {pet.Status}");
    }
    Console.WriteLine();
  }
}