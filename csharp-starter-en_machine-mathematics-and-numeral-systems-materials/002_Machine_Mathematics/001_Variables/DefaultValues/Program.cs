using System;

namespace DefaultValues
{
    class Program
    {
        static void Main()
        {
            // At line 11, create a variable, named a of type int and assign it no value.

            int a = ; 
            int b = 2;
          
            // At line 11 - ERROR: Use of uninitialized local variable is prohibited!

            Console.WriteLine(a);
            Console.WriteLine(b);

            // Delay.
            Console.ReadKey();
        }
    }
}
