using System;

namespace Methods
{
    class Program
    {
        // Parameter, passed by value, is deleted when method returns a value
        static void AddTwo(int a)
        {
            a += 2;
            Console.WriteLine("Value of int a = {0}", a);
        }

        static void Main()
        {
            Console.WriteLine("Enter a number:");

            // Accept input from the user and converts it to an integer value
           
            string number = Console.ReadLine();
            int result = Int32.Parse(number);

            Console.WriteLine("Value of result = {0}", result);

            // As an argument not variable result is passed itself but its copy.
            AddTwo(result);
            Console.WriteLine("Value of result = {0}", result); 

            // Delay.
            Console.ReadKey();
        }
    }
}
