﻿using System;

// An example of a correct multiple return from method.

namespace Methods
{
    class Program
    {
        static string Compare(int value1, int value2)
        {
            if (value1 < value2)
            {
                return "Comparison (Less Than)";
            }
            else if (value1 > value2)
            {
                return "Comparison (Greater Than)";
            }

            return "Comparison (Equal)"; // Try comment this line.
        }

        static void Main()
        {
            int operand1 = 1, operand2 = 2;

            string result = Compare(operand1, operand2);

            Console.WriteLine(result);

            // Delay.
            Console.ReadKey();
        }
    }
}
