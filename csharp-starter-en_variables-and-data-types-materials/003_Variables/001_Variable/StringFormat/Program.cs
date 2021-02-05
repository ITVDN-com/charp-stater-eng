using System;

namespace StringFormat
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            Console.WriteLine("This is number {0}", a);

            int b = 2, c = 3;
            Console.WriteLine("These are numbers {0} and {1}", b, c);
            Console.WriteLine("These numbers are reversed {1} and {0}", b, c);

            // Delay.
            Console.ReadKey();
        }
    }
}
