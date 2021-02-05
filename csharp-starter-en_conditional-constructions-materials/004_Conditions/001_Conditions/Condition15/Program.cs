using System;

// The operator of multiple choice - switch-case (switch).

namespace Condition
{
    class Program
    {
        static void Main()
        {
            // We offer the user to select a drink.
            Console.WriteLine("Coffee cup sizes: 1 = Small, 2 = Medium, 3 = Large");
            Console.Write("Please make your choice: ");

            // Takes input from the user.
            string coffeeSize = Console.ReadLine();

            int cost = 0;

            // If case operator has code in its body, then "falling" is not supported.
            // For organizing of "falling" it is possible to use operator - goto
            switch (coffeeSize)
            {
                case "1":
                    cost += 25;
                    break;
                case "2":
                    cost += 25;
                    goto case "1";
                case "3":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("The wrong choice. Please choose 1, 2, or 3.");
                    break;
            }

            if (cost != 0)
            {
                Console.WriteLine("Pay {0} cents.", cost);
                Console.WriteLine("Thank you!");
            }
            else
            {
                Console.Write("Please, repeat your choice.");
            }
            
            // Delay.
            Console.ReadKey();
        }
    }
}
