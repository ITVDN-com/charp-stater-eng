using System;

// Loop - while. (with jump statement - continue)

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

            while (counter < 3)
            {
                counter++;
                Console.WriteLine("Counter {0}", counter);

                continue;

                Console.WriteLine("This line will not be executed.");
            }

            Console.WriteLine("{0} iterations were performed.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
