using System;

namespace Methods
{
    class Program
    {
        // A reference to the the source arguments is passed, copy of the argument is not created.
        static void AddTwo(ref int a)
        {
            a = a + 2;
            Console.WriteLine("Value of int a = {0}", a);
        }

        static void Main()
        {
            Console.WriteLine("Enter a number:");

            // Accept input from the user and convert it to an integer value
            
            string number = Console.ReadLine();
            int result = Int32.Parse(number);

            Console.WriteLine("Value of result = {0}", result);

            // As an argument the variable result passes itself, not its copy.
            AddTwo(ref result);
            Console.WriteLine("Value of result = {0}", result);

            // Delay.
            Console.ReadKey();
        }
    }
}
