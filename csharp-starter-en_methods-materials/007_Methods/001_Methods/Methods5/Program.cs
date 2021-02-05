using System;

// Methods (Functions). 

namespace Methods
{
    class Program
    {
        /// <summary>
        /// The addition of two integers.
        /// </summary>
        /// <param name="summand1">The first summand</param>
        /// <param name="summand2">The second summand</param>
        /// <returns>Sum</returns>
        static int Add(int summand1, int summand2)
        {
            return summand1 + summand2;
        }

        static void Main()
        {
            int summand1 = 2, summand2 = 3;

            int sum = Add(summand1, summand2);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            // Delay.
            Console.ReadKey();
        }
    }
}
