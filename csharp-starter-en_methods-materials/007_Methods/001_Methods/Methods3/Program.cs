using System;

// Methods (Functions).

namespace Methods
{
    class Program
    {        
        static string Function()
        {
            string word = "Hello Max!";

            return word;
        }

        static void Main()
        {            
            string word = Function();

            Console.WriteLine(word);

            // Delay.
            Console.ReadKey();
        }
    }
}
