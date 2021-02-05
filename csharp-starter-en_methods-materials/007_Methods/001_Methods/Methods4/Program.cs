using System;

// Methods (Functions).

namespace Methods
{
    class Program
    {
        // In line 13, create a method, named Function, which receives one string argument and returns a string value.
        // In the body of the method assign string local variable sentence concatenation of a string and argument, 
        // using the keyword return, return the value of the variable sentence.
        
        static string Function(string name)
        {
            string sentence = "Hello " + name + "!";

            return sentence;
        }

        static void Main()
        {
            // In the body of method Main in line 25, create a string local variable with name sentence, 
            // assign it the return value of method Function, to which we passed a line Alex as an argument.

            string sentence = Function("Alex");

            Console.WriteLine(sentence);

            // Delay.
            Console.ReadKey();
        }
    }
}
