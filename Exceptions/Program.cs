namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string content = File.ReadAllText(@"C:\Users\spart\Desktop\hola mundo.txt");
            Console.WriteLine(content);

            try
            {
                throw new Exception("Something went wrong");
                //string content2 = File.ReadAllText(@"C:\Users\spart\Desktop\hola mundo2.txt");
                //Console.WriteLine(content2);
            }
            catch( FileNotFoundException error)
            {
                Console.WriteLine(error.Message);
            }
            catch( Exception error )
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.WriteLine("The program continues...");    
            }


            try
            {
                var beer = new Beer()
                {
                    Brand = "Minerva",
                    //Name = "Stout"
                };

                Console.WriteLine(beer.ToString());
            }
            catch(InvalidBeerException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }

    public class InvalidBeerException: Exception
    {
        public InvalidBeerException(): base("The beer doesn't have either a Name or Brand value set")
        {

        }
    }

    class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }


        public override string ToString()
        {
            // return base.ToString();
            if (Name == null || Brand == null) {
                throw new InvalidBeerException();
            }

            return $"This beer is a {Name} from {Brand}";
        }
    }
}
