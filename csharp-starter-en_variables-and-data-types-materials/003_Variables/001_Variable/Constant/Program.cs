using System;

// Constant - is a memory area, that keeps some value that can not be changed.

namespace Constant
{
    class Program
    {
        static void Main()
        {
            // On the 13-th line we create a double typed constant, named "pi" and assign a value of 3.141 to it.

            const double pi = 3.141;

            // On the 17-th line we display the value of the constant - pi.

            Console.WriteLine(pi);

            // Attempting to assign a new value to the constant results in a compile-time error.

            //pi = 2.71828183; 

            // Delay.
            Console.ReadKey();
        }
    }
}
