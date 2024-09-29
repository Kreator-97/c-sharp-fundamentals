// in order to use the list we must use the next namespace below:
using System.Collections.Generic;

// The list are specialized objects that contains methods that can be used to manage a collections of items.

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(5);
            numbers.Add(340);

            Console.WriteLine(numbers.Count);

            List<string> names = new()
            {
                "Donato", "Alondra", "Valentina"
            };

            Console.WriteLine($"Total names: {names.Count}");

            names.Insert(0, "Arturo"); // insert a item in the specified position
            Show(names);


            if (names.Contains("Arturo") )
            {
                Console.WriteLine("Arturo is in the list");
            }
            else
            {
                Console.WriteLine("Arturo is not in the list");
            }

            Console.WriteLine("Clearing items from names");

            int index = names.IndexOf("Donato");

            Console.WriteLine($"Donato is on the index {index}");

            names.Sort();
            Show(names);

            names.Clear();
            Console.WriteLine($"Total names: {names.Count}");
        }

        public static void Show(List<string> names)
        {
            Console.WriteLine("--- Showing names ---");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
