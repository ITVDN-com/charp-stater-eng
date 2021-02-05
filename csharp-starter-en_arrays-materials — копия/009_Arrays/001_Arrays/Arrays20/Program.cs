using System;

// Keyword params allows us to determine the parameter of the method that receives a variable number of arguments.

namespace Arrays
{
    class Program
    {
        static void ShowArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }

        static void Main()
        {
            ShowArray(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            // Delay.
            Console.ReadKey();
        }
    }
}
