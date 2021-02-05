using System;

// Method with output parameters.

namespace Methods
{
    class Program
    {
        // Output parameters need to be changed in the method body, otherwise there will be an error.
        
        static int Method(out int a)
        {
            // Comment!
            a = 1;

            return 2;
        }

        static void Main()
        {
            int operand;

            // out - allows to pass uninitialized variables to the method.
            
            int result = Method(out operand);

            Console.WriteLine("{0}; {1};", operand, result);

            // Delay.
            Console.ReadKey();
        }
    }
}
