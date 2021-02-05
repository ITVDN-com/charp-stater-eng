using System;

// Bitwise logical statements. (&, |)

// For example: 
// We have an I / O port or a register with a particular value in it.
// We need to turn on a device, managed by the first bit, setting the first bit to 1.
// then we need to turn off the device, resetting the first bit to 0.
//  1 1 1 1   0 0 0 0  -  the initial value of I / O port.
//  7 6 5 4   3 2 1 0  -  numeration of bits of control devices.

namespace Logic
{
    class Program
    {
        static void Main()
        {
            byte port = 0xF0;     // 1 1 1 1   0 0 0 0  -  the initial value of I / O ports.
            byte mask = 0x02;     // 0 0 0 0   0 0 1 0  -  mask of turning on the device, managed by the first bit.
                                  // 1 1 1 1   0 0 1 0  - result
            Console.WriteLine("port = {0:X}", port); // situation with a light bulb in the room

            port = (byte)(port | mask);  // Turn on the device, managed by the first bit.
            Console.WriteLine("port = {0:X}", port);

                                  // 1 1 1 1   0 0 1 0  - value when swiched on.
            mask = 0xFD;          // 1 1 1 1   1 1 0 1  -  Create a mask of turning off the device, managed by the first bit. 
                                  // 1 1 1 1   0 0 0 0
                                                          
                                   

            port = (byte)(port & mask);  // Turn off the device, managed by the first bit.
            Console.WriteLine("port = {0:X}", port);

            // Delay.
            Console.ReadKey();
        }
    }
}
