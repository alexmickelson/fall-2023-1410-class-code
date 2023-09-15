public class Pet
{
  public string Name;
  public string Species;
  public AdoptionStatus Status;

  public Pet(string name, string species)
  {
    Name = name;
    Species = species;
    Status = AdoptionStatus.NotAdopted;
  }
}