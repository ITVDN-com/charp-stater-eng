using System;

// The multiple choice operator - switch-case (switch).

namespace Condition
{
    class Program
    {
        static void Main()
        {
            // Ask the user to enter a number
            Console.WriteLine("Enter number 1 or 2: ");

            // Accept input from the user.
            string number = Console.ReadLine();


            // in line 21, we create a construction of multiple choice - switch, 
            // and pass the variable - (number) as an expression of the selector. 

            switch (number)  // (number) — selector expression.
            {
                // In the body of switch-case, in lines 29 and 35,
                // create two case operators with case expressions "1" и "2" respectively.

                // If the value of the selector expression matches one of the values ​​of the case expressions,
                // then the body of the operator case, which the constant expression coincided with the selector expression, is performed. 

                case "1":    // "1" — case (constant) expression.
                    {
                        Console.WriteLine("One");                                       // Branch 1
                        // Exit of the switch.
                        break;
                    }
                case "2":   // "2" — case (constant) expression.
                    {
                        Console.WriteLine("Two");                                        // Branch 2
                        break;
                    }

                // In line 44, create (optional) operator default, the body of which is performed
                // if the value of the selector does not match any of the values ​​of case expressions. 

                default:
                    {
                        Console.WriteLine("You entered a number which is not 1 or 2.");       // Branch 3
                        break;
                    }

                // If the switch does include default operator, control is transferred outside switch.     
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
