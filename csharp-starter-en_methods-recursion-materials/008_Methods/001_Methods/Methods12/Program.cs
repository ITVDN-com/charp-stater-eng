using System;

// Finding of the greatest common divisor (GCD) of two integers

namespace Recursion
{
    class Program
    {
        static int Calculate(int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return Calculate(b, a % b);
        }

        static void Main()
        {
            Console.WriteLine("Finding of the greatest common divisor of two integers");

            int a = 15, b = 33;

            Console.WriteLine("a = {0}, b = {1}, GCD = {2};", a, b, Calculate(a, b));

            Console.ReadKey();
        }

        #region The second variant of solution

        static int Calculate2(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }
        
        #endregion
    }
}
