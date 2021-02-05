using System;

// Methods with optional parameters. 

namespace Methods
{
    class Program
    {
        // The method is invoked in the same way if there are overloads.
        static void Operation(string value1 = "val", int value2 = 10, double value3 = 12.2)
        {
            Console.WriteLine("{0}, {1}, {2}", value1, value2, value3);
        }

        static void Main()
        {
            Operation();                     // the 1st overload.
            Operation("NewVal");             // the 2nd overload.
            Operation("NewVal", 11);         // the 3rd overload.
            Operation("NewVal", 11, 3.14);   // the 4th overload.


            // It is not possible to put the 3nd parameter value3 = 12.2, instead of the 2nd parameter value2 = 10!
            // 12.2 cannot be converted to int — C # is trying to leave as default the third parameter, but not the second.
            //Operation("Newval", 12.2); // ERROR!

            // In this case, it is possible to use named parameters.
            // They consist of a parameter name, a colon, and the value, that we pass.

            Operation("NewVal", value3: 12.2);
            Operation(value2: 33, value3: 12.2);


            // Delay.
            Console.ReadKey();
        }
    }
}
