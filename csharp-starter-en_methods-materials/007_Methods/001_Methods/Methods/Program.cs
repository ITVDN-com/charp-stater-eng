using System;

// Methods (Procedures).

namespace Methods
{
    class Program
    {
        // In line 12, create a method, named Procedure, which receives nothing and returns nothing.
        // In the body of the method, in line 14 we display the string - Hello!        

        static void Procedure()
        {
            Console.WriteLine("Hello!");
            //return;
        }

        static void Main()
        {
            // In the body of the main method in line 21, invoke method Procedure.

            Procedure();

            // Delay.
            Console.ReadKey();
        }
    }
}
