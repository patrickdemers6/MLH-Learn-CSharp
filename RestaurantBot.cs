using System;

namespace MLH_Learn_CSharp
{
    class RestaurantBot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to One Eye'd Jacks!\nWhat would you like to eat?");
            String outputString = "Sounds great, I'll get your ";

            // get food
            outputString += Console.ReadLine() + " and ";

            // get drink
            Console.WriteLine("\nWhat would you like to drink?");
            String drink = Console.ReadLine();
            outputString += drink;

            // water can have a lemon
            if (drink.ToLower() == "water")
            {
                Console.WriteLine("\nWould you like a lemon?");
                outputString += Console.ReadLine().ToLower()[0] == 'y' ? " with a lemon" : "";
            }

            // any drink can have ice
            Console.WriteLine("\nWould you like ice?");
            outputString += Console.ReadLine().ToLower()[0] == 'y' ? ", with ice" : "";

            // get the tip
            Console.WriteLine("\nGreat! How much would you like to tip?");
            Double tip = Convert.ToDouble(Console.ReadLine());

            while (tip < 0)
            {
                Console.WriteLine("You can't tip negative! Try again.");
                tip = Convert.ToDouble(Console.ReadLine());
            }

            outputString += ". Thank you for your tip of $" + tip + ".";

            Console.WriteLine("\n" + outputString);

            return;
        }
    }
}
