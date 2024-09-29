

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Functions are intended to pack a functionality into a reusable piece of code.

            ShowMessage("Hello world");
            ShowMessage("Hello world");
            ShowMessage("Hello world");
            ShowMessage("Hello world");

            var result = Sum(20, 20);

            Console.WriteLine($"The result is {result}");

            var name = GetName();
            Console.WriteLine(name);

            

        }


        static void ShowMessage(string message) {
            Console.WriteLine(message);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static string GetName() 
        {
            return "My name is Donato";
        }
    }
}
