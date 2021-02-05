using System;

// Ternary conditional operator.

// Ternary (tertiary) operator [?:] .
// Ternary operator [?:] is a short form of conditional if ... else.
// [?:] - includes three operands - ( condition ? If condition is TRUE : If condition is FALSE )

//    Algorithm of work of ternary operation (logical expression)? 1 statement: statement 2: (logical expression) ? statement 1 : statement 2
//    1. A logical expression is calculated (condition).
//    2. If logical expression is true, value of the statement 1 is calculated, otherwise - value of statement 2. 
//    3. The calculated value is returned.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 6, b = 2, max = 0;

            // Assign the return value of the ternary operator to variable max.

            max = (a > b) ? a : b;   // If:  (a > b), then return a  ELSE: return b;

            Console.WriteLine(max);

            // Delay.
            Console.ReadKey();
        }
    }
}
