using DB;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFrameworkSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbContextOptionsBuilder<LearningCsharpContext> optionBuilder = new DbContextOptionsBuilder<LearningCsharpContext>();
            optionBuilder.UseSqlServer("Server=KREATOR; Database=learning-csharp; User=root; Password=password; TrustServerCertificate=True");

            bool again = true;
            int option = 0;

            do
            {
                ShowMenu();
                Console.WriteLine("Choose an option");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Show(optionBuilder);
                        break;
                    case 2:
                        Add(optionBuilder);
                        break;
                    case 3:
                        Update(optionBuilder);
                        break;
                    case 4:
                        Delete(optionBuilder);
                        break;
                    case 5:
                        Console.WriteLine("Exiting from program");
                        again = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Option selected doesn't exist. Showing menu");
                        ShowMenu();
                        break;
                }
            }
            while (again);
        }

        static void ShowMenu()
        {
            Console.WriteLine("\n1. Show items");
            Console.WriteLine("2. Add item");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");
        }

        static void Show(DbContextOptionsBuilder<LearningCsharpContext> optionBuilder)
        {
            Console.Clear();
            Console.WriteLine("Beers in the database");

            // The using keyword in this context works on all clases that implement the interface IDisposable
            using (var context = new LearningCsharpContext() )
            {
                //List<Beer> beers = context.Beers.OrderBy((beer) => beer.Id).ToList();
                List<Beer> beers2 = (from b in context.Beers
                                     orderby b.Id
                                     select b).Include((b) => b.Brand).ToList();

                foreach (var beer in beers2)
                {
                    Console.WriteLine($"ID: {beer.Id} - Name: {beer.Name} - Brand: {beer.Brand.Name}");
                }
            }
        }

        static void Add(
            DbContextOptionsBuilder<LearningCsharpContext> optionBuilder
        )
        {
            Console.Clear();
            Console.WriteLine("Add a new beer");

            Console.WriteLine("Write the name of the beer");
            string name = Console.ReadLine();

            Console.WriteLine("Write the id of the brand");
            int brandId = int.Parse(Console.ReadLine());

            using (var context = new LearningCsharpContext(optionBuilder.Options))
            {
                Beer beer = new Beer()
                {
                    Name = name,
                    BrandId = brandId,
                };

                context.Add(beer);
                context.SaveChanges();
            }
        }

        static void Update(
            DbContextOptionsBuilder<LearningCsharpContext> optionBuilder
        )
        {
            Console.Clear();
            Show(optionBuilder);

            Console.WriteLine("Update one beer");
            Console.WriteLine("Write the id of the beer you want to update");

            int id = int.Parse(Console.ReadLine());

            using (var context = new LearningCsharpContext(optionBuilder.Options))
            {
                Beer beer = context.Beers.Find(id);

                if (beer == null)
                {
                    Console.WriteLine($"The beer with id {id} doesn't exist");
                    return;
                }

                Console.WriteLine("Write the new name");
                string name = Console.ReadLine();

                Console.WriteLine("Write the new brand id");
                int brandId = int.Parse(Console.ReadLine());

                beer.Name = name;
                beer.BrandId = brandId;

                context.Entry(beer).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        static void Delete(
            DbContextOptionsBuilder<LearningCsharpContext> optionBuilder)
        {
            Console.Clear();
            Show(optionBuilder);

            Console.WriteLine("Write the id of the beer to delete");
            int id = int.Parse(Console.ReadLine());

            using (var context = new LearningCsharpContext(optionBuilder.Options)) {
                Beer? beer = context.Beers.Find(id);

                if (beer == null) {
                    Console.WriteLine($"Beer with id {id} does not exist");
                    return;
                }

                context.Beers.Remove(beer);
                context.SaveChanges();
            }
        }
    }
}
