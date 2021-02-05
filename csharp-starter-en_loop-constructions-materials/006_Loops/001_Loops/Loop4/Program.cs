using System;

// Loop - while.

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
            }

            Console.WriteLine("{0} iterations were performed.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
