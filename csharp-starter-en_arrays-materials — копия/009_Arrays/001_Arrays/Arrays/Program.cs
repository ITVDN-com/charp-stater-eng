using System;

// Arrays (one-dimensional array).

namespace Arrays
{
    class Program
    {
        static void Main()
        {

            // In line 14, create an array of integer elements, named array which has 5 elements

            int[] array = new int[5];

            // In line 18, assign the element of our array with 0 index a value of 10

            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            // In line 26, display the value of array element with the 0 index 

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

            // Delay.
            Console.ReadKey();
        }
    }
}
