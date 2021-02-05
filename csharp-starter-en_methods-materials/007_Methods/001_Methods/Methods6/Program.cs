using System;

// Methods (Functions). 

namespace Methods
{
    class Program
    {
        //	Methods-predicates - methods that return a Boolean value.

        static bool And(bool a, bool b)
        {
            return a && b;
        }

        static void Main()
        {
            bool operand1 = true, operand2 = true;

            bool result = And(operand1, operand2);

            Console.WriteLine("{0} && {1} = {2}", operand1, operand2, result);

            // Delay.
            Console.ReadKey();
        }
    }
}
