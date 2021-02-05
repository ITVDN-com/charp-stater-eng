using System;

// Loop (loop with a counter) - for (with jump statement - break).

namespace Loop
{
    class Program
    {
        static void Main()
        {

            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);

                break;

                Console.WriteLine("This line will not be executed.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
