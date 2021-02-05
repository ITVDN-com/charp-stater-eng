using System;

// Increment and Decrement Operators. (Unary)

namespace IncDec
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----- Post-increment");
            
            byte number1 = 0;            
            Console.WriteLine(number1++); // First it displays the value of number1, then increases it by 1.
            Console.WriteLine(number1);

            Console.WriteLine("----- Pre-increment"); 

            byte number2 = 0;
            Console.WriteLine(++number2); // First it increases the value of number2 by 1, then displays it.

            Console.WriteLine("----- Post-decrement"); 

            sbyte number3 = 0;
            Console.WriteLine(number3--);  // First it displays the value of number3, then decreases it by 1.
            Console.WriteLine(number3);

            Console.WriteLine("----- Pre-decrement"); 

            sbyte number4 = 0;
            Console.WriteLine(--number4); // First it decreases the value of number2 by 1, then displays it.

            // Delay.
            Console.ReadKey();
        }
    }
}
