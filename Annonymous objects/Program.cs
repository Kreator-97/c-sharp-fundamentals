// Annoymous objects are objects that don't need a class to be created
// They can be created in a literal form
// A disavantage is that all objects created in this way is that all of them are readonly.
// That means we cannot modify or update their properties.

namespace Annonymous_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var donato = new
            {
                name = "Donato",
                country = "México"
            };

            Console.WriteLine(donato);

            var beers = new[]
            {
                new { name = "Red", brand = "Delirium" },
                new { name = "London porter", brand = "Fuller" }
            };
        }
    }
}
