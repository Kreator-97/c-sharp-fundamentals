using System;

namespace Variables {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world");

            int age = 27;

            Console.WriteLine(age++);

            foreach(var arg in args) { 
                Console.WriteLine(arg);
            }

            age = 20;
            Console.WriteLine($"Mi edad es {age++}");
        }
    }
}
