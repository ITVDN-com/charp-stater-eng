using System;

// Conditional - if-else (with two branches).

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1, b = 2;

            // If the body of if or else blocks consists of a single expression, then you can omit the braces.

            if (a < b)
                Console.WriteLine("a is less than b");           // Branch 1 
            else
                Console.WriteLine("a is not less than b");   // Branch 2
            
            // Delay.
            Console.ReadKey();
        }
    }
}
