using System;

// Logical shift.

namespace Logic
{
    class Program
    {
        static void Main()
        {           
            byte operand = 0x81;              // 1000 0001    
            Console.WriteLine("Number before shift: {0:X}", operand);
            
            // Logical shift to the left.

            operand = (byte)(operand << 2);   // 0000 0100   
                                              //On the right zeroes always enter

            Console.WriteLine("Number after left shift: {0:X}", operand);

            // Logical shift to the right.

            operand = (byte)(operand >> 1);   // 0000 0010
                                              //On the left - if the number is positive,
                                              //zeroes enter and if negative - ones enter
            Console.WriteLine("Number after right shift: {0:X}", operand);

            // Delay.
            Console.ReadKey();
        }
    }
}
