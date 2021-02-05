using System;

// Method overloads. 

namespace Methods
{
    class Program
    {
        static void Operation()                                         // the 1st overload.
        {
            Operation("val", 10, 12.2);
        }

        static void Operation(string value1)                            // the 2nd overload.
        {
            Operation(value1, 10, 12.2);
        }

        static void Operation(string value1, int value2)                // the 3rd overload.
        {
            Operation(value1, value2, 12.2);
        }

        static void Operation(string value1, int value2, double value3) // the 4th overload.
        {
            Console.WriteLine("{0},{1},{2}", value1, value2, value3);
        }

        static void Main()
        {
            Operation();                     // the 1st overload.
            Operation("NewVal");             // the 2nd overload.
            Operation("NewVal", 11);         // the 3rd overload.
            Operation("NewVal", 11, 3.14);   // the 4th overload.
            
            // Delay.
            Console.ReadKey();
        }
    }
}
