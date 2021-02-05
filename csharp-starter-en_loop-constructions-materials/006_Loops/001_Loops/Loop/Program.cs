using System;

// Operator of an unconditional jump  - goto.

namespace Loop
{
    class Program
    {
        static void Main()
        {

        // Start- is the label, to which the goto operator will jump to.

        Start: Console.WriteLine("Hello!");
            goto Start;

        }
    }
}
