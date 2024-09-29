using System.Text.Json;

namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beer beer = new Beer()
            {
                Brand = "Corona",
                Name = "Light"
            };

            Console.WriteLine(beer);

            // serializing json
            string json = JsonSerializer.Serialize(beer);
            Console.WriteLine(json);

            Beer beer2 = JsonSerializer.Deserialize<Beer>(json);
            Console.WriteLine(beer2);
        }
    }

    public class Beer
    {
        public string? Name { get; set; }
        public string? Brand { get; set; }

        public override string ToString()
        {
            return $"{Brand} - {Name}";
        }
    }
}
