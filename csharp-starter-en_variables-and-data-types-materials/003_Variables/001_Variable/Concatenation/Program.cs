using System;

// Concatenation - is the operation of joining two character strings end-to-end. 

namespace Concatenation
{
    class Program
    {
        static void Main()
        {
            // 1 variant.
            string word1 = "Hello ";
            string word2 = "World!";            
            string phrase = word1 + word2;
            Console.WriteLine(phrase);
            
            // 2 variant.
            Console.WriteLine("Hello " + "World!");

            // Delay.
            Console.ReadKey();
        }
    }
}
