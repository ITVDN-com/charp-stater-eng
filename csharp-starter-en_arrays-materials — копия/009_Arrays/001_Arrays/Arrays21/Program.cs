using System;

// A parameter with the keyword params, should be at the last position in the parameter list of a method.

namespace Arrays
{
    class Program
    {
        static void ShowArray(string name, params int[] array)
        {
            Console.Write(name);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }

        static void Main()
        {
            ShowArray("Numbers: ", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            // Delay.
            Console.ReadKey();
        }
    }
}
