using System;
using System.Collections.Generic;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var beers = new List<Beer>
            {
                new Beer("Minerva", "México"),
                new Beer("Satory", "Japan"),
                new Beer("Porter", "Germany"),
            };

            Console.WriteLine($"There are {beers.Count} in stock");
            
            Console.WriteLine("\n---Showing beers---");

            foreach( var beer in beers )
                Console.WriteLine(beer);

            Console.WriteLine("\n---Selecting items usig Linq---");
            // Selecting item
            // the select keyword allows you to select the field you need from a list.
            var beerNames = from b in beers
                            select new
                            {
                                Name = b.Name,
                                Letters = b.Name.Length,
                            };

            foreach( var beerName in beerNames )
                Console.WriteLine($"name: {beerName.Name} has {beerName.Letters} letters");

            Console.WriteLine("\n---filtering using Linq---");

            var beersMexico = from b in beers
                              where b.Country == "México"
                              select b;

            foreach (var beer in beersMexico)
                Console.WriteLine(beer.ToString());

            Console.WriteLine("\n---Sorting using Linq---");
            var orderedBeers = from b in beers
                               orderby b.Country
                               select b;

            foreach (var beer in orderedBeers)
                Console.WriteLine(beer.ToString());
        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Beer(string name, string country)
        {
            this.Name = name;
            this.Country = country;
        }

        public override string ToString()
        {
            return $"This is a beer called {Name} from {Country}";
        }
    }
}
