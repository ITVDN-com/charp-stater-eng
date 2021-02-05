using System;

// Methods (Functions).

namespace Methods
{
    class Program
    {
        // In line 12, we create a method, named Function, which receives nothing and returns a string value.
        // In the body of the method, using the keyword return, return line - Hello!

        static string Function()
        {
            return "Hello!";
        }

        static void Main()
        {
            // In the body of the main method in line 22, create a string local variable with the name @ string 
            // and assign the return value of method Function to it.

            string @string = Function();
                       
            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}
