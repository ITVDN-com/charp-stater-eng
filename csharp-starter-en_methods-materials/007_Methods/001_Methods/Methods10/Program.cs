using System;

// Methods with output parameters (out).

namespace Methods
{
    class Program
    {
        static int Method(out int a)
        {
            // Output parameters need to be changed in the method body, otherwise there will be an error.
            a = 2;
            return a * 2;
            a = 5;
        }

        static void Main()
        {
            int operand;

            // out - allows passing uninitialized variables to the method.
            
            int result = Method(out operand);

            Console.WriteLine("{0}; {1};", operand, result);

            // Delay.
            Console.ReadKey();
        }
    }
}
