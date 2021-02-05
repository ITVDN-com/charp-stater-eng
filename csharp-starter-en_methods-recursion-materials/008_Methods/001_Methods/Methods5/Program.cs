using System;

// Returning values from method Main ()

// Upon completion of the program it is possible to return the value of the Main () method to the calling process or operating system.

// The return value of the method Main () can only be of type int.

// As a rule, the value, returned by the Main (), indicates normal completion of the program
// or its emergency completion due to the prevailing abnormal conditions of  performance. 
// Zero return value usually indicates normal completion of the program, 
// and all other values ​​indicate the type of occurred error.

namespace Methods
{
    class Program
    {       
        static int Main()
        {
            Console.WriteLine("Hello world!");

            // Delay.
            Console.ReadKey();

            return 0;
        }
    }
}
