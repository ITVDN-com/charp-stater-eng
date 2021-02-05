using System;

// Comparing values of different types.

namespace Comparison
{
    class Program
    {
        static void Main()
        {
            bool result;

            int a = 1;
            float b = 2.0f;
            result = a < b;   // Comparing values of int and double types is allowed.
            
            string c = "Hello";
            //result = c < a; // Comparing values of int and string types is not allowed.

            bool flag = true;
            //result = a < flag; // Comparing values of int and bool types is not allowed.

            // Delay.
            Console.ReadKey();
        }
    }
}
