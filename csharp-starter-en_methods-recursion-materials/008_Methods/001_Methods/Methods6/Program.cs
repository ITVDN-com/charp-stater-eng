using System;

// Returning values from method Main ()

// Overload of method Main () - is possible.

// The entry point to the program may be the method Main (), which returns a void or int value.

namespace Methods
{
    class Program
    {
        
        // Overload. (is not an entry point)
        static string Main(string argument)
        {
            return "Hello " + argument + "!";
        }

        
        // Entry point to the program.
        static int Main()
        {
            string @string = Main("World");

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();

            return 0;
        }
    }
}
