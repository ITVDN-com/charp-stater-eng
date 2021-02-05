using System;

// Ternary conditional operator. Nested ternary operators.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            // Determining quadrants where a given point is situated .
            // For simplicity, we agree that the point does not lie in the center of coordinates and coordinate axes,
            // it means that x and y - can not be 0.

            int x = -5, y = -3;


            // It is not recommended to make nested ternary operators because it impairs code reading.

            //                ------------------------------------------------------------------------------------------------
            string quadrant = (x > 0) ? ((y > 0) ? "I quadrant" : "IV quadrant") : ((y > 0) ? "II quadrant" : "III quadrant");
            //                          ----------------------------------------   ------------------------------------------  

            // ... or in a such way
            
            //         ----------------------------------------------------------------------------------------
            quadrant = x > 0 ? (y > 0 ? "I quadrant" : "IV quadrant") : (y > 0 ? "II quadrant" : "III quadrant");
            //                 -------------------------------------    ----------------------------------------

            // ... or in a such way

            //         -------------------------------------------------------------------------------------
            quadrant = x > 0 ? y > 0 ? "I quadrant" : "IV quadrant" : y > 0 ? "II quadrant" : "III quadrant";
            //                 ------------------------------------   --------------------------------------


            Console.WriteLine(quadrant);

            // Delay.
            Console.ReadKey();
        }
    }
}
