namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            bool isWorking = false;

            if (isWorking)
            {
                Console.WriteLine("I'M BUSY");
            }
            else
            {
                Console.WriteLine("I'M FREE");
            }


            isOpen("Donato");
            
            static void isOpen(string name)
            {
                if(name == "Donato" )
                {
                    Console.WriteLine("Is open");
                }
            }

            var date = new DateTime();
            Console.WriteLine(date);
        }
    }
}
