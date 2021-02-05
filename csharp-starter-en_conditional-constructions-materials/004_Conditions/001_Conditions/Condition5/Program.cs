using System;

// Ternary conditional operator.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 3, b = 2, c = -5, max = 0;

            max = a > b ? c = a : c = b; // first с = а, only then max = c 

            Console.WriteLine(max);
            Console.WriteLine(c);

            // Delay.
            Console.ReadKey();
        }
    }
}
