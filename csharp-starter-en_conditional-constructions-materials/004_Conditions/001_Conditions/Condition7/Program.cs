using System;

// Ternary conditional operator.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            string @string = "Hello ";

            Console.WriteLine("Enter your login:");

            // At line 17, we create a string typed variable named login, and take user input and put into variable login
            
            string login = Console.ReadLine();

            // At line 21, we assign with concatenation the return value of ternary operator to variable @string
           
            @string += login == "Admin" ? "Administrator" : "User"; 

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}
