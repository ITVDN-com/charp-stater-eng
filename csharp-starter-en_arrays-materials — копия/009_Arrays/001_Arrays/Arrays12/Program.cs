using System;

// Jagged Arrays.

namespace Arrays
{
    class Program
    {
        static void Main()
        {

            int[][] jagged = new[]
            {
               new int[] { 1, 2 },
               new int[] { 1, 2, 3, 4, 5 },
               new int[] { 1, 2, 3 }
            };

            // In the outer loop, iteration through all nested arrays is performed.
            for (int i = 0; i < jagged.Length; ++i)
            {
                // In the inner loop, access to each element of the nested array is performed.
                for (int j = 0; j < jagged[i].Length; ++j)
                {
                    Console.Write("{0} ", jagged[i][j]);
                }
                Console.Write("\n");
            }


            // Delay.
            Console.ReadKey();
        }
    }
}
