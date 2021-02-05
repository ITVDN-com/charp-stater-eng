using System;

namespace Assignment
{
    class Program
    {
        static void Main()
        {
            // RULE:
            // All arithmetic operations executed with two values of (byte, sbyte, short, ushort) types 
            // return a value of "int" type.

            // Addition with assignment operator (+=) for values of type "byte".
            byte variable1 = 0;

            //variable1 = variable1 + 5;       // ERROR: Attempt of implicit conversion of value of result from "int" type  to "byte" type.
            //variable1 = (byte)variable1 + 5; // ERROR: Converts a byte to type byte, before the operation of addition.
      
            variable1 = (byte)(variable1 + 5); // Not the best solution.
            
            variable1 += 5;                    // Elegant solution.           

            //variable1 += 5000;               // Error. The value of the right part should not exceed the maximum value limit of the type of variable
           
            // RULE:
            // For int, uint, long and ulong types, there is no type conversion results of arithmetic operations.
           

            #region operations with assignment...

            // Addition assignment.
            int variable2 = 0;
            variable2 = variable2 + 5;
            variable2 += 5;

            //  Subtraction assignment.
            uint variable3 = 0;
            variable3 = variable3 - 5;
            variable3 -= 5;

            // Multiplication assignment.
            long variable4 = 0;
            variable4 = variable4 * 5;
            variable4 *= 5;

            // Division assignment.
            ulong variable5 = 0;
            variable5 = variable5 / 5;
            variable5 /= 5;

            // Remainder after division assignment.
            long variable6 = 0;
            variable6 = variable6 % 5;
            variable6 %= 5;
            
            #endregion

            // RULE:
            // /For int, uint, long and ulong types, there is no type conversion results of arithmetic operations....
        

            //  Addition assignment.
            float variable7 = 0;
            variable7 = variable7 + 5;
            variable7 += 5;

            // Multiplication assignment.
            double variable8 = 0;
            variable8 = variable8 * 5;
            variable8 *= 5;

            // Delay.
            Console.ReadKey();
        }
    }
}
