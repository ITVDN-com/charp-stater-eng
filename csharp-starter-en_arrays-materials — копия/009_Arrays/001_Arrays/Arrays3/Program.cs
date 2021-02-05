using System;

// Arrays (one-dimensional array).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            // In line 14, we create an array of integer elements, named array, with 5 elements in it
            // in the block of initializer fill it with values ​​1,2,3,4,5

            int[] array = new int[5] { 1, 2, 3, 4, 5 };

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
