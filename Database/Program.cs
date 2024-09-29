using System.ComponentModel;
using System.Data.SqlClient;

namespace Database
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                BeerDB beerDB = new BeerDB("KREATOR", "learning-csharp", "root", "password");
                bool again = true;
                int option = 0;

                do
                {
                    ShowMenu();
                    Console.WriteLine("Choose an option please: \n");
                    option = int.Parse(Console.ReadLine());

                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            Show(beerDB);
                            break;
                        case 2:
                            Add(beerDB);
                            break;
                        case 3:
                            Edit(beerDB);
                            break;
                        case 4:
                            Delete(beerDB);
                            break;
                        case 5:
                            again = false;
                            Console.WriteLine("Exiting from program");
                            break;
                        default:
                            Console.WriteLine($"Option {option} doesn't exist. Showing menu.");
                            break;
                    }

                }
                while (again);
            }
            catch (SqlException e)
            {
                Console.WriteLine("An error has ocurred when trying to connect to the database");
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine("An uncaught exception was thrown");
                Console.WriteLine(e);
            }
        }


        public static void ShowMenu()
        {
            Console.WriteLine("\n-----Menu-----");
            Console.WriteLine("1. Show");
            Console.WriteLine("2. Add");
            Console.WriteLine("3. Edit");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Quit");
        }


        public static void Show(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Listing beers from database: ");

            List<Beer> beers = beerDB.GetAll();

            foreach (var beer in beers)
            {
                Console.WriteLine(beer);
            }
        }

        public static void Add(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("Adding a new beer");

            Console.WriteLine("Write the name");
            string name = Console.ReadLine();

            Console.WriteLine("Write the id of the brand");
            int brandId = int.Parse(Console.ReadLine());

            var beer = new Beer(name, brandId);

            beerDB.Add(beer);
        }

        public static void Edit(BeerDB beerDB)
        {
            Console.Clear();
            Show(beerDB);

            Console.WriteLine("Edit beer");
            Console.WriteLine("Write the id of your beer to edit");
            int id = int.Parse(Console.ReadLine());

            Beer? beer = beerDB.GetById(id);

            if (beer == null)
            {
                Console.WriteLine("The beer with the given ID doesn't exist");
                return;
            }

            Console.WriteLine("Write the new name");
            string name = Console.ReadLine();

            Console.WriteLine("Write id of the brand");
            int brandId = int.Parse(Console.ReadLine());

            //var Beer = new Beer(id, name, brandId);
            beer.Name = name;
            beer.BrandId = brandId;

            beerDB.Edit(beer);
        }

        public static void Delete(BeerDB beerDB)
        {
            Console.Clear();
            Show(beerDB);

            Console.WriteLine("Delete beer");
            Console.WriteLine("Write the id of your beer to delete");
            int id = int.Parse(Console.ReadLine());

            Beer? beer = beerDB.GetById(id);

            if (beer == null)
            {
                Console.WriteLine("The beer with the given ID doesn't exist");
                return;
            }

            beerDB.Delete(beer.Id);
            Console.WriteLine($"The beer with name {beer.Name} was deleted");
        }
    }
}

