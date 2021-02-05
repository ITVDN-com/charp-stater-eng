using System;

/*   
 *  Short-circuit calculation - technique works as follows:
 *  If the first operand in the operation AND (&&) is false, the second operand not calculated,
 *  because the full expression in any case will be false.
 */

namespace ShortLogicComputing
{
    class Program
    {
        static void Main()
        {
            int MIN_VALUE = 1;
            int denominator = 0;
            int item = 2;

            // The condition, does not work using the technique of short-circuit calculation.
            // Because the operation && (And) is calculated from left to right,
            // This logically equivalent statement will not work!

            if (((item / denominator) > MIN_VALUE) && (denominator != 0))
            {
                Console.WriteLine("We are in the block IF");
            }
            else
            {
                Console.WriteLine("We are in the block ELSE");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
