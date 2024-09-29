namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Showing a list of numbers");
            List<int> myListOfNumbers = new(10);

            myListOfNumbers.Add(12);
            myListOfNumbers.Add(24);
            myListOfNumbers.Add(36);

            myListOfNumbers.ShowItems();

            List<string> todos = new List<string>(10);
            Console.WriteLine($"show item at the position 20: {myListOfNumbers.GetItem(20)}");
            Console.WriteLine("\n");

            Console.WriteLine("Showing the list of things to do");
            todos.Add("Study react native");
            todos.Add("Study english");
            todos.Add("read books");
            todos.Add("Measure in which things I'm wasting my time");

            todos.ShowItems();

            Console.WriteLine("\n");
            Console.WriteLine("Showing list of people");

            List<People> people = new List<People>(10);
            people.Add(new People("Donato", "México"));

            people.ShowItems();
        }
    }

    // Generics allow you to define that any method, class of function can work with diferents types.

    public class List<T>
    {
        private T[] _items;
        private int _index = 0;

        public List(int limit)
        {
            _items = new T[limit];
        }

        public void Add(T item)
        {
            if(_index < _items.Length)
            {
                _items[_index] = item;
                _index++;
            }
        }

        public void ShowItems()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                var item = _items[i];
                Console.WriteLine($"{i+1}.- {item}");

            }
        }

        public T GetItem(int i)
        {
            if(i <= _index && i >=0)
            {
                return _items[i];
            }

            return default(T);
            //throw new Exception("index outside bounds");
        }

    }
    public class People
    {
        public string name { get; set; }
        public string country { get; set; }

        public People(string name, string country)
        {
            this.name = name;
            this.country = country;
        }

        public override string ToString()
        {
            return $"Hola, soy me llamo {name} y soy de {country}";
        }
    }
}
