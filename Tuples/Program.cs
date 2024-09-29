// The Tuple is a data structure that allows you to create a collection of values that must respect all the data types
// given in the declaration. You can add both primitive and object types inside them.
// You can modify or update the values of a tuple
// parentheses () are the character used to specify a tuple.

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // declaration of a tuple
            (int id, string name) product = (1, "Cerveza stout");
            Console.WriteLine(product);

            product.name = "Porter";
            Console.WriteLine(product);

            var person = (1, "Donato");
            Console.WriteLine(person);

            person.Item2 = "Melissa";
            Console.WriteLine(person);

            var people = new[]
            {
                (1, "donato"),
                (2, "Melissa"),
                (3, "Carol")
            };

            Console.WriteLine("\n---Showing people---");
            foreach (var currentPerson in people)
            {
                Console.WriteLine(currentPerson);    
            }

            Console.WriteLine("\n---City information---");
            var cityInfo = GetCoords();
            Console.WriteLine(cityInfo);

            // destructuring data from a typle type
            var (_, lng, _) = GetCoords();
            Console.WriteLine($"The longitud is ${lng}");
        }

        public static (float lat, float lng, string) GetCoords()
        {
            float lat = 19.12134f;
            float lng = -99.23232f;

            return (lat, lng, "Ciudad de México");
        }
    }
}
