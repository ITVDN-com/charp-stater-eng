using System;

// The multiple choice operator - switch-case (switch).

namespace Condition
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number of day of week: 1-2-3-4-5-6-7: ");
            
            string myDay = Console.ReadLine();

            // Convert a value of string variable myDay to an integer value 
            // And store it in a variable, named day, of type int

            int day = Convert.ToInt32(myDay);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday.");
                    break;
                case 2:
                    Console.WriteLine("Monday.");
                    break;
                case 3:
                    Console.WriteLine("Tuesday.");
                    break;
                case 4:
                    Console.WriteLine("Wednesday.");
                    break;
                case 5:
                    Console.WriteLine("Thursday.");
                    break;
                case 6:
                    Console.WriteLine("Friday.");
                    break;
                case 7:
                    Console.WriteLine("Saturday.");
                    break;
                default:
                    Console.WriteLine("You have entered a nonexistent day of week.");
                    break;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
