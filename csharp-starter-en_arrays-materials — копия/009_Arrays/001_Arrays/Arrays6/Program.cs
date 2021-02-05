using System;

// Arrays (one-dimensional array).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            string[] array = new string[5];


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
