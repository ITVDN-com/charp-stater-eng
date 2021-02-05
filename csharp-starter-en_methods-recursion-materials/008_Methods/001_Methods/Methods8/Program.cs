using System;

// Recursion (complex recursion). 

// Complex recursion - an invocation of a method by itself, using another method. 

namespace Methods
{
    class Program
    {
        static void Recursion(int counter)
        {
            counter--;

            Console.WriteLine("The first part of method Recursion: {0}", counter);

            if (counter != 0)
                Method(counter);

            Console.WriteLine("The second part of method Recursion: {0}", counter);
        }

        static void Method(int counter)
        {
            Console.WriteLine("The first part of method Method: {0}", counter);

            Recursion(counter);

            Console.WriteLine("The second part of method Method: {0}", counter);
        }

        static void Main()
        {
            Method(3);

            // Delay.
            Console.ReadKey();
        }
    }
}
