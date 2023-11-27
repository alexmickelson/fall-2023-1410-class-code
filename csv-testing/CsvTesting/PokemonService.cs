using System.Globalization;
using CsvHelper;

public static class PokemonService
{
    public static IEnumerable<Pokemon> ReadCsv()
    {
        using (var reader = new StreamReader("pokemon.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<Pokemon>();
            return records.ToList();
            // return records;
        }
    }
}