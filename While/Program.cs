namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here

            int limit = 2000;
            var i = 0;

            while ( i < limit)
            {
                Console.WriteLine($"Iteración {++i}");
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Time: {elapsedMs}");
        }
    }
}
