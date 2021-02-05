using System;

// sizeof Operator - Allows you to get the size of a value in bytes for the specified type
// sizeof Operator Can be applied only to these types:
// byte, sbyte, short, ushort, int, uint, long, ulong, float, double, decimal, char, bool.
// Returned  values of the sizeof operator ​​are of int type.

namespace Sizeof
{   
    class Program
    {
        static void Main()
        {
            int doubleSize = sizeof(double);
            Console.WriteLine("Sizeof double type: {0} bytes", doubleSize);

            Console.WriteLine("sizeof int type: {0} bytes.", sizeof(int)); 
            Console.WriteLine("sizeof bool type: {0} byte.", sizeof(bool)); 
            Console.WriteLine("sizeof long type: {0} bytes.", sizeof(long)); 
            Console.WriteLine("sizeof short type: {0} bytes.", sizeof(short));  
            
            // Delay.
            Console.ReadKey();
        }
    }
}
