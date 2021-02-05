using System;

// Arrays (one-dimensional array).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[5];

            // Filling an array.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }

            // Display values of array elements.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
