using System;

namespace Alias
{
    class Program
    {
        static void Main()
        {
            // Data type C# (alias)
            // On line 11 we created an alias byte type variable, named "a" and assigned a value of 2 to it.
            byte a = 2;

            // System full data type
            // On line 15 we created a full name byte type variable, named "b" and assigned a value of 2 to it.
            Byte b = 2;

            // On lines 18 and 19 we display the values of the variables "a" and "b".
            Console.WriteLine(a);
            Console.WriteLine(b);

            // Delay.
            Console.ReadKey();
        }
    }
}
