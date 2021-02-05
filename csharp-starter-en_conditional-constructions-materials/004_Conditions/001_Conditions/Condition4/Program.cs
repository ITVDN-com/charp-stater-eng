using System;

// Conditional- if-else (with several branches). Cascade of conditionals.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 2, b = 2;

            if (a < b)      // Cascade of conditionals
            {
                Console.WriteLine(" a is less than b");   // Branch 1
            }
            else if (a > b) // go to a new check 
            {
                Console.WriteLine("a is greater than b");   // Branch 2
            }
            else 
            {
                Console.WriteLine("a is equal to b");  // Branch 3
            }
            
            // Delay.
            Console.ReadKey();
        }
    }
}
