// See https://aka.ms/new-console-template for more information

using System;

namespace FundamentosCSHARP { 
    class Program
    {
        static void Main(string[] args)
        {
            byte num = 0;
            long bigNumber = 2999999999;
            object persona = new { nombre = "Donato", apellido = "Monzón" };
            DateTime now = DateTime.Now;
            Console.WriteLine("Hello, World!");
            Console.WriteLine(num);
            Console.WriteLine(bigNumber);
            Console.WriteLine(now);
            Console.WriteLine(persona);
        }
    }
}
