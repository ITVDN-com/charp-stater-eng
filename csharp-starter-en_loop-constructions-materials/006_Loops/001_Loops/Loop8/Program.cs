using System;

// Loop - do-while.

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

            do
            {
                counter++;
                Console.WriteLine("Counter {0}", counter);
            }
            while (counter < 3);

            Console.WriteLine("{0} iterations were performed.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
