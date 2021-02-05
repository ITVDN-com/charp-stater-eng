using System;

// Loop - for (loop with a counter).

namespace Loop
{
    class Program
    {
        static void Main()
        {

            // for (initialization of the iteration counter; condition; change of the counter) {loop body}
           
            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);
            }

            //counter = 0; //  counter - is not available outside the loop for.

            // Delay.
            Console.ReadKey();
        }
    }
}
