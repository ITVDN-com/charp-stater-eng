using System;

// Ternary conditional operator. Restrictions related to the type safety.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            double b = 2.3;
            int max;

            // Statements [?] and [:]  - should be of the same type.

            max = (int)((a > b) ? a : b);

            // ... or in a such way

            max = (a > b) ? a : (int)b;

            Console.WriteLine(max);

            // Delay.
            Console.ReadKey();
        }
    }
}
