using System;

// Difference between float, double, decimal types.

namespace FloatDoubleDecimal
{
    class Program
    {
        static void Main()
        {
            float variable1 = 0.12345678901234567890f;
            double variable2 = 0.12345678901234567890d;
            decimal variable3 = 0.12345678901234567890m;

            Console.WriteLine(variable1);
            
            Console.WriteLine(variable2);
            
            Console.WriteLine(variable3);

            //----------------------------------------------
            Console.WriteLine(0.12345678901234567890);    // double - default
            Console.WriteLine(0.12345678901234567890f);   // f - float
            Console.WriteLine(0.12345678901234567890m);   // m - decimal

            // Delay.
            Console.ReadKey();
        }
    }
}
