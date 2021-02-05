using System;

// Loop - while. 

namespace Loop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess the hidden colour, you have a maximum of 5 attempts.");
            Console.WriteLine("To exit the game, type - exit and press enter.");

            const int maxAttempt = 5; // The maximum allowable number of attempts.
            int attempt = 0;          // Counter of attempts.
            string color = "red";     // Conceived color.

            while (attempt < maxAttempt)
            {
                attempt++;
                Console.WriteLine("Attempt {0}:", attempt);
                
                string value = Console.ReadLine();

                if (value == "exit")
                {
                    break;
                }

                if (value != color)
                {
                    continue;
                }

                Console.WriteLine("Congratulations, you have guessed with {0} attempts!", attempt);
                break;
            }

            Console.WriteLine("Game over!");

            // Delay.
            Console.ReadKey();
        }
    }
}
