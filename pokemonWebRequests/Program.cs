// Create a New HttpClient object.
HttpClient client = new HttpClient();

// Call asynchronous network methods in a try/catch block to handle exceptions
try
{
  HttpResponseMessage response = await client.GetAsync("https://pokeapi.co/api/v2/generation/1");
  response.EnsureSuccessStatusCode();
  string responseBody = await response.Content.ReadAsStringAsync();
  // Above three lines can be replaced with new helper method below
  // string responseBody = await client.GetStringAsync(uri);

  Console.WriteLine(responseBody);
}
catch (HttpRequestException e)
{
  Console.WriteLine("\nException Caught!");
  Console.WriteLine("Message :{0} ", e.Message);
}
