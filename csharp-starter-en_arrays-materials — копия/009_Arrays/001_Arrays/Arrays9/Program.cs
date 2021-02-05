using System;

// Arrays (two-dimensional array).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            // The compiler determines the size of the array based on the initialization expression.
            int[,] array = {
                             { 1, 2, 3 },
                             { 4, 5, 6 },
                             { 7, 8, 9 }
                           };

            Console.WriteLine(array);


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.Write("\n");
            }


            // Delay.
            Console.ReadKey();
        }
    }
}
