namespace MethodOverwriting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer donato = new();
            Console.WriteLine(donato.Introduce());

            SalePlusIVA sale1 = new(10);

            sale1.Add(10);
            sale1.Add(230.23m);
            sale1.Add(30.45m);

            Console.WriteLine(
                $"The total of the sale is {sale1.CalcTotal()}"
            );
        }
    }

    class Person
    {

        // we are indicating this method can be overwritten
        public virtual string Introduce()
        {
            return "Hello I'm a person";
        }
    }

    class Developer: Person
    {
        //  we are overidding this method from the parent Class
        public override string Introduce()
        {
            // base keyword allows you to retrieve the base funcionality from the original method
            return $"{base.Introduce()} \nHello I'm a Developer";
        }
    }

    public class Sale
    {
        private decimal[] _amounts;
        private int _limit;
        private int _taken = 0;


        public Sale(int limit)
        {
            this._limit = limit;
            this._amounts = new decimal[limit];
        }

        public void Add(decimal amount) 
        {
            if(_taken < _limit)
            {
                _amounts[_taken] = amount;
                _taken++;
            }
        }

        public virtual decimal CalcTotal()
        {
            decimal total = 0;
            foreach (var amount in _amounts)
            {
                total += amount;
            }

            return total;
        }
    }

    public class SalePlusIVA: Sale
    {
        public SalePlusIVA(int limit): base(limit) {}

        public override decimal CalcTotal()
        {
            var subtotal = base.CalcTotal();

            return subtotal * 1.16m;
        }
    } 
}
