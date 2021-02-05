using System;

// Methods with variable parameters (ref = in/out).

namespace Methods
{
    class Program
    {
        // If in the body of the method there is changing of the value of a variable, passed by reference,
        // its value will be changed everywhere

        static int Method(ref int a)
        {
            int b = a * 2;
            a = 5;
            return b;
        }

        static void Main()
        {
            int operand = 2;

            int result = Method(ref operand);

            Console.WriteLine("{0}; {1};", operand, result);

            // Delay.
            Console.ReadKey();
        }
    }
}
