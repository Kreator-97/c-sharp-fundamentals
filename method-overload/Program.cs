namespace MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Math math = new();

            var result = math.Sum(12, 40);
            Console.WriteLine(result);

            result = math.Sum("10", "1");
            Console.WriteLine(result);

            result = math.Sum(12.05, 1.34);
            Console.WriteLine(result);

            result = math.Sum([0,1,1,2,3,5,8,13,21,34,]);
            Console.WriteLine(result);
        }
    }

    class Math
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        // we are using method overload
        // In here, we are not overwriting the Sum method, but extend it
        public double Sum(string a, string b)
        {
            return double.Parse(a) + int.Parse(b);
        }

        public double Sum(double[] numbers )
        {
            double result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }

            return result;
        }
    }
}
