using System;

// Using keywords in C# language as identifiers.

namespace At
{
    class Program
    {
        static void Main()
        {
            //int bool = 5;      // Not allowed
            int @bool = 7;       // Allowed
            Console.WriteLine(@bool);


            //  // The @ Character is not part of the identifier, so, @ myVariable - is the same as that of myVariable.
           
            string @myVariable = "Hello";
            Console.WriteLine(myVariable);


            // Delay.
            Console.ReadKey();
        }
    }
}
