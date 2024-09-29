using opp.Models;

namespace OPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Bebida bebida = new("Cerveza", 1000);


            Console.WriteLine("Bebiendo la bebida");
            Console.WriteLine(bebida);

            Console.WriteLine("Se ha bebido 200");
            bebida.Beberse(200);

            Console.Write("Queda: ");
            Console.Write(bebida.Cantidad);

            Cerveza cerveza = new("Minerva", 950);
            cerveza.Beberse(300);

        }
    }
}