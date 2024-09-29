namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a literal list of fishes
            IFish[] value = [
                new Shark("Tornado", 250),
                new Shark("Megadolon", 200)
            ];

            IFish[] sharks = value;

            ShowFishes(sharks);
        }

        public static void ShowFishes(IFish[] fishes)
        {
            Console.WriteLine("Showing fishes");

            foreach (var fish in fishes)
            {
                Console.WriteLine(fish.Swim());
            }
        }
    }

    public class Shark: IAnimal, IFish
    {

        public Shark(string name, int speed)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public string Name { get; set; }

        public int Speed { get; set; }

        public string Swim()
        {
            return $"The fish {Name} is swimming at {Speed} miles per hour";
        }
    }

    public interface IAnimal
    {
        public string Name { get; set; }
    }

    public interface IFish
    {
        public int Speed { get; set;}
        public string Swim();
    }
}
