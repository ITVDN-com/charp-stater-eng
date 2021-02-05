using System;

// Flags string formatting.

namespace FlagFormating
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("C format: {0:C}", 99.9);      // Output in currency format
            Console.WriteLine("F format: {0:##}", 99.935);   // Output values ​​with fixed precision.
            Console.WriteLine("N format: {0:N}", 99999);     // Standard numeric formatting
            Console.WriteLine("X format: {0:X}", 255);       // Output in hexadecimal format.
            Console.WriteLine("D format: {0:D}", 0xFF);      // Output in decimal format.
            Console.WriteLine("E format: {0:E}", 9999);      // Output in exponential notation.
            Console.WriteLine("G format: {0:G}", 99.9);      // Output in a general format.
            Console.WriteLine("P format: {0:P}", 99.9);      // Output in percentage format.
            
            // Delay.
            Console.ReadKey();
        }
    }
}
