using System;

/*   
 *  Short-circuit calculation - technique works as follows:
 *  If the first operand in the operation AND (&&) is false, the second operand is not calculated,
 *  because the full statement in any case will be false.
 */

namespace ShortLogicComputing
{
    class Program
    {
        static void Main()
        {
            int MIN_VALUE = 1;
            int denominator = 2;
            int item = 4;

            // The condition, which works with the use of technique of short-circuit calculation.
            // If this statement is calculated completely, the division in the second operand, 
            // would generate a divided by 0 exception.

            if ((denominator != 0) && (item / denominator) > MIN_VALUE) // Leave one operator &
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
