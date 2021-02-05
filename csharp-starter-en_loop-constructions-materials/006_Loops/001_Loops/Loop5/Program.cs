using System;

// Loop - while. (with jump statement - break)

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

                break;

                Console.WriteLine("This line will not be executed.");
            }

            Console.WriteLine("{0} iteration was performed.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
