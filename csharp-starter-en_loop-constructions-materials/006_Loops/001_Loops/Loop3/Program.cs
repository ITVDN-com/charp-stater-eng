﻿using System;

// Operator of an unconditional jump  - goto.

namespace Loop
{
    class Program
    {
        static void Main()
        {
            bool condition = false;

            if (condition == true)
            {
                goto Label;
            }

            Console.WriteLine("First line");

        Label:
            Console.WriteLine("Second line");

            // Delay.
            Console.ReadKey();
        }
    }
}
