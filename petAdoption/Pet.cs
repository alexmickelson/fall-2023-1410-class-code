public class Pet
{
  private string name;
  private string species;
  private AdoptionStatus status;

  public Pet(string name, string species)
  {
    this.name = name;
    this.species = species;
    status = AdoptionStatus.NotAdopted;
  }

  public string GetName()
  {
    return name;
  }

  public string GetSpecies()
  {
    return species;
  }

  public AdoptionStatus GetAdoptionStatus()
  {
    return status;
  }
  public void SetAdoptionStatus(AdoptionStatus newStatus)
  {
    if(newStatus == AdoptionStatus.Reserved)
      return;
      
    status = newStatus;
  }
}