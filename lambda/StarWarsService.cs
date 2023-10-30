using System.Text.Json;

public class StarWarsService
{
  public async Task<StarWarsPerson> GetStarWarsPerson()
  {
    HttpClient client = new HttpClient();
    HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/people/1");
    HttpContent data = response.Content;
    string dataAsString = data.ToString();

    return JsonSerializer.Deserialize<StarWarsPerson>(dataAsString);
  }
}