using System;

// Conditional - if - else (with two branches).

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 34, b = 22;

            if (a < b)  // If the condition is matched, perform the body of the if block.
            {
                Console.WriteLine("a is less than b");               // Branch 1
            }
            else        // Otherwise, perform the body of the else block.       
            {
                Console.WriteLine("a is not less than b");       // Branch 2
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
