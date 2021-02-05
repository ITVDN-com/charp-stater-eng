using System;

// Loop - do-while. 

// Factorial of number n (denoted n!) — is the product of all natural numbers,
// from 1 to n:
//     n! = 1 * 2 * 3 * ... * n
//     0! = 1

// In combinatorics, the factorial of a natural number n is interpreted as the number of permutations of n elements.
// For example, for the set {A, B, C, D} of 4 elements: 4! = 1 * 2 * 3 * 4 = 24 permutations:

//     ABCD  BACD  CABD  DABC
//     ABDC  BADC  CADB  DACB
//     ACBD  BCAD  CBAD  DBAC
//     ACDB  BCDA  CBDA  DBCA
//     ADBC  BDAC  CDAB  DCAB
//     ADCB  BDCA  CDBA  DCBA

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int counter = 4;
            int factorial = 1;

            Console.Write("Factorial of number: {0}! = ", counter);

            do
            {
                // First tmultiplication, then decrement. 
                factorial *= counter--;

                // This line is equivalent to:

                //factorial = factorial * counter;
                //counter = counter - 1;
            }
            while (counter > 0);

            Console.WriteLine("{0}", factorial);

            // Delay.
            Console.ReadKey();
        }
    }
}
