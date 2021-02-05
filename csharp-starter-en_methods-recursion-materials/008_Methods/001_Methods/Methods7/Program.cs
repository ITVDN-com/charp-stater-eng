using System;

// Recursion (simple recursion). 

// In the body of method Recursion on the 19th line the method Recursion is invoked recursively.
// Simple recursion - an invocation of the method by itself (self-invocation). During each invocation the method copied.

namespace Methods
{
    class Program
    {
        static void Recursion(int counter)
        {
            counter--;

            Console.WriteLine("The first part of the method: {0}", counter);

            if (counter != 0)
                Recursion(counter);

            Console.WriteLine("The second part of the method: {0}", counter);
        }

        static void Main()
        {
            Recursion(3);

            // Delay.
            Console.ReadKey();
        }
    }
}
