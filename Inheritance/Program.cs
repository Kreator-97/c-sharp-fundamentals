namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new("Donato", "Monzón", 27);
            Console.WriteLine(person.Greet());


            Doctor doctor = new("Donato", "Monzón", 27, "Cardiology");
            Console.WriteLine(doctor.IntroduceMyself());
        }
    }

    class Person {
        protected string _name; // we add a "_" prefix because the property is private.
        protected string _lastName;
        int age;

        public Person(string name, string lastName, int age)
        {
            this._name = name;
            this._lastName = lastName;
            this.age = age;
        }

        public string Greet()
        {
            return $"Hello, my name is {_name} {_lastName} and I'm {age} years old";
        }
    }

    class Doctor: Person
    {
        private readonly string _specialty;

        public Doctor(string name, string lastName, int age, string specialty ) : base(name, lastName, age) // using parent constructor
        {
            Console.WriteLine("Creating instance of doctor");
            this._specialty = specialty;
        }

        public string IntroduceMyself()
        {
            return $"Hello, my name is {_name} and have a specialty in {_specialty}";
        }
    }
}
