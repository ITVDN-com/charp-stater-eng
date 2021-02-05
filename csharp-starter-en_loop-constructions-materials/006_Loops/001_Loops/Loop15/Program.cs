using System;

// Loop for,- nested loop for. (Building a square, using asterisks - *)

namespace Loop
{
    class Program
    {
        static void Main()
        {

            for (int i = 0; i < 10; i++)
            {
                // Display one line of 10 asterisks.
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }

                // Start a new line. .
                Console.WriteLine();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
