using System;

// Loop - do-while. (with jump statement - break)

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

                break;

                Console.WriteLine("This line will not be executed.");
            }
            while (counter < 3) ;

            Console.WriteLine("{0} iteration is performed.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
