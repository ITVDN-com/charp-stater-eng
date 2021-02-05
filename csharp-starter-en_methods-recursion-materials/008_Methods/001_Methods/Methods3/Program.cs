using System;

// Named arguments of methods

namespace Methods
{
    class Program
    {
        static int Difference(int height, int width)
        {
            return height - width;
        }

        static void Main()
        {
            // It is possible to invoke (call) a method in this way:
            int difference = Difference(6, 5);

            //difference = Difference(5, 6);

            Console.WriteLine("The difference is: {0}", difference);

            // And like this too:
            difference = Difference(width: 5, height: 6);

            Console.WriteLine("The difference is: {0}", difference);

            Console.ReadKey();
        }
    }
}
