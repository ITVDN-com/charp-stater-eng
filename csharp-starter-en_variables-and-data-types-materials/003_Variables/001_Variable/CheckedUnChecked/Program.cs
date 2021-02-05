using System;

// The combination of checks and overflow checking restriction.


namespace CheckedUnChecked
{
    class Program
    {
        static void Main()
        {
            sbyte a = 126;
            sbyte b = 127;

            // Check for overflow.
          
            checked
            {
                a++;

                // Do not check for overflow.
            
                unchecked
                {
                    b++;
                }

                a++;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
