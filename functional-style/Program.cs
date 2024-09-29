
// It is a way to define a function
// This function is going to be saved as a variable
// You can define a function type
using System.Runtime.InteropServices;

Operation MySum = Functions.Sum;
Operation MyMul = Functions.Mul;

Console.WriteLine($"5 plus 5 is {MySum(5, 5)}");
Console.WriteLine($"5 times 5 is {MyMul(5, 5)}");

// We are assigning two functions to this variable
// We exect all linked function when invoking the method
Show CW = Console.WriteLine;
CW += Functions.Show;
CW("Hello world");

# region Action
// Action allows you to define a function that receive many parameters for a function that always returns void
Action<string, string?> ShowMessage = Console.WriteLine;
Functions.Some("Donato", "Monzón", ShowMessage);
# endregion

# region Func
// Func allow you to define a function that receive many parameters but they can return a value
// This always return a value, so you need to especify the returned type 
Func<int> randomNumber = () => new Random().Next(0, 100);

// This is a function that receive 2 parameter of type int, a return a int
// The last type is the returned type.
Func<int, int, int> multiply = (a, b) => a + b;
Func<int, int> RandomNumberLimit = (limit) => new Random().Next(0, limit);

Console.WriteLine(randomNumber());
# endregion

# region Predicate
// With predicates you can save function with receive only one argument and return always a boolean
Predicate<string> hasSpace = (word) => word.Contains(' ');
Console.WriteLine(hasSpace("Donato Monzón"));

# endregion

# region Lambda Expressions
// Annonymous function and lambda expression
Action<string, string> Log = (a, b) => Console.WriteLine(a, b);
#endregion

# region Delegates
// delegates are variables that allow you to store a function in a variable
public delegate void Show(string message);
delegate int Operation(int a, int b);
# endregion

public class Functions
{
    public static int Sum(int a, int b) => a + b;

    public static int Mul(int a, int b) => a * b;

    public static void Show(string message) => Console.WriteLine(message.ToUpper());

    public static void Some(string name, string lastName, Action<string, string> callback)
    {
        Console.WriteLine("Doing something interesting in DB");
        callback(name, lastName);
    }
}
