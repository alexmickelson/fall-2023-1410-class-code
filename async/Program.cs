
using System.Text.Json;

var url = "https://fakestoreapi.com/products";

var client = new HttpClient();
HttpResponseMessage response = await client.GetAsync(url);
var bodyString = await response.Content.ReadAsStringAsync();
// Console.WriteLine(bodyString);

var listOfProducts = JsonSerializer.Deserialize<IEnumerable<Product>>(bodyString);


foreach(var product in listOfProducts)
{
  Console.WriteLine(product);
}