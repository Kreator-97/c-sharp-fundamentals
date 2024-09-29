namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Sale sale1 = new(200.39, "Donato");
            Sale sale2 = new(305.30, "Alo");

            Console.WriteLine(sale1.GetSale());
            Console.WriteLine($"El total sin iva es {(sale1.Total / 1.16).ToString("#.00")}");
            Console.WriteLine(sale2.GetSale());

            Animal dog = new("Dog");

            Console.WriteLine(dog.Examine());
        }
    }

    // using main constructor
    class Sale(double total, string customerName)
    {
        private double total = total;
        private readonly string customerName = customerName;
        private readonly DateTime date = DateTime.Now;

        static public void Show()
        {
            Console.WriteLine("Hola soy una venta");
        }

        public string GetSale()
        {
            return $"La venta es de {customerName} el dia {date.ToLongDateString()} por el monto de ${total}";
        }

        // accessor for reading total property in the Sale class
        public double Total
        {
            // getter: We can recover the value of this property and apply some formats and styles.
            get
            {
                return total;
            }

            // setter: Value if the new value that is going to be set. We can apply logic here.
            set
            {
                if( value < 0 )
                {
                    value = 0;
                    total = value;
                }
            }
        }
    }

    // using old constructor
    class Animal
    {
        private readonly string species;

        public Animal (string species)
        {
            this.species = species;
        }

        public string Examine()
        {
            return $"This animal is from {species} species";
        }

    }
}
