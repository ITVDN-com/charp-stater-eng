using System;

// Logical statements.

// For example: 
// To check the conditional statement A < x < B.( it can not be written directly in a conditional statement,
// because each statement must be of two operands.)
// The correct way to write: if ( A < x && x < B).

namespace Logic
{
    class Program
    {
        static void Main()
        {
            int A = 0, B = 5, x = 3;


            if (A < x && x < B) // A < x < B
            {
                Console.WriteLine("Number {0} is in the range of numbers from {1} to {2}.", x, A, B);
            }
            else
            {
                Console.WriteLine("Number {0} is out of range of numbers from {1} to {2}.", x, A, B);
            }


            // Delay.
            Console.ReadKey();
        }
    }
}
