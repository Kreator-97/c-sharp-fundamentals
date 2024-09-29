namespace LINQ_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var countries = new List<Country>
            {
                new Country("México", "America"),
                new Country("Bélgica", "Europa"),
                new Country("Alemania", "Europa")
            };

            var beers = new List<Beer>
            {
                new Beer("Corona", "México"),
                new Beer("Delirium", "Bélgica"),
                new Beer("Erdinger", "Alemania")
            };

            Console.WriteLine("---Using join with LINQ---");

            var BeersWithContinent = from beer in beers
                                    join country in countries
                                    on beer.Country equals country.Name
                                    select new
                                    {
                                        Name = beer.Name,
                                        Country = beer.Country,
                                        Continent = country.Continent
                                    };

            foreach (var beer in BeersWithContinent)
            {
                Console.WriteLine($"The beer {beer.Name} is from {beer.Continent}");
            }
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

    }
    public class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }

        public Country(string name, string continent)
        {
            this.Name= name;
            this.Continent = continent;
        }
    }
}
