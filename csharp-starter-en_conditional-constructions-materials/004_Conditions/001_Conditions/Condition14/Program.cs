using System;

// The multiple choice operator - switch-case (switch). Falling.
 

namespace Condition
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number of day of week:: 1-2-3-4-5-6-7: ");
            
            string day = Console.ReadLine();

            switch (day)
            {
                // For empty case operators "falling" from one operator to another is allowed. 
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("This day of week is a - Working day.");
                    break;
                case "6":
                case "7":
                    Console.WriteLine("This day of week is a - Weekend.");
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
