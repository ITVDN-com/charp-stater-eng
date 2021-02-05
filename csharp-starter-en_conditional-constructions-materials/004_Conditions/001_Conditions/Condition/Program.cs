using System;

// Conditional - if (with one branch).

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1, b = 2; // we create two integer variables

            // In line 15, create a conditional if, with a checking: a is less than b   

            if (a < b)      // If the condition is matched, perform the body of the conditional.
            {
                Console.WriteLine("a is less than b");     // Branch 1
            }
            
            // Delay.
            Console.ReadKey();
        }
    }
}
