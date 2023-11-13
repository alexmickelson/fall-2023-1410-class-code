public class PokemonCard
{
  public string Name { get; set; }
  public int HP { get; set; }
  public string Type { get; set; }
  public PokemonCard(string name, int hp, string type)
  {
    Name = name;
    HP = hp;
    Type = type;
  }

  public void SaveToFile(string filePath)
  {
    int.Parse("skdnflskefn");
    // if any attributes are null / not filled
    string cardData = $"{Name},{HP},{Type}";

    // what if file already exists
    if(File.Exists(filePath))
    {
      // make an exception happen
      throw new FileAlreadyExistsException($"cannot save pokemon card file", filePath);
    }

    File.WriteAllText(filePath, cardData);
  }

  public static PokemonCard LoadFromFile(string filePath)
  {
    // file is an invalid format: not a text file
    // file does not exist
    // what if the file has unexpected characters
    string cardData = File.ReadAllText(filePath);

    // what if commas are not correct in file
    // maybe too many commas
    // maybe too few
    string[] cardParts = cardData.Split(',');

    string name = cardParts[0];

    // what if cardParts[1] is not an int?
    int hp = int.Parse(cardParts[1]);
    string type = cardParts[2];

    PokemonCard card = new PokemonCard(name, hp, type);
    return card;
  }

  public override string ToString()
  {
    return $"Name: {Name}, HP: {HP}, Type: {Type}";
  }
}


public class FileAlreadyExistsException : Exception
{
  public string FilePath { get; set; }
  public FileAlreadyExistsException(string message, string path) : base(message)
  {
    FilePath = path;
  }
  public override string ToString()
  {
    var parentException =  base.ToString();
    return $"filepath: {FilePath}\n{parentException}";
  }



  
}