using System;

// Ban overflow checking- (unchecked)
// overflow checking forbiden.

namespace UnChecked
{
    class Program
    {
        static void Main()
        {
            sbyte a = 127; // 0111 1111

            // Uncheck overflow.
            unchecked
            {
                a++; 
            }

            // 127 + 1 = -128 // 1000 0000
            Console.WriteLine(a);

            // Delay.
            Console.ReadKey();
        }
    }
}
