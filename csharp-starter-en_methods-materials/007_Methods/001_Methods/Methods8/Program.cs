using System;

// Example: Use of the watching operator for the protection of nominal variant.

namespace Methods
{
    class Program
    {
        static string Function(string name)
        {
            // Check. for errors, end the work.

            if (name == "fool")   // Guard operator (watcher).
            {
                return "You have used an invalid word.";
            }

            // Code of nominal variant.

            string sentence = "Hello " + name + "!";

            return sentence;
        }

        static void Main()
        {
            string sentence = Function("Mary");

            Console.WriteLine(sentence);

            // Delay.
            Console.ReadKey();
        }
    }
}
