namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Create a new array of strings
            string[] bestFriends = new string[7];

            bestFriends[0] = "Alex";
            bestFriends[1] = "Esteban";
            bestFriends[2] = "Albert";

            foreach (var friend in bestFriends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine($"Length: {bestFriends.Length}");

            string[] favoriteCountries =
            [
                "México",
                "España",
                "Canada",
                null,
                null
            ];

            for (int i = 0; i < favoriteCountries.Length; i++)
            {
                Console.WriteLine(favoriteCountries[i]);
            }



        }
    }
}
