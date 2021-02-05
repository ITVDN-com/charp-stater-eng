using System;

// checking a statement. - (checked)


namespace Checked
{
    class Program
    {
        static void Main()
        {
            sbyte a = 127; //0111 1111 b

            // Check overflow.
            checked
            {
                a++; // Error: compiler-level
                //             
            }

            // 127 + 1 = -128 //1000 0000 b
            Console.WriteLine(a);

            // Delay.
            Console.ReadKey();
        }
    }
}
