using System;

// Method overload. 

namespace Methods
{
    class Program
    {
        // Overloaded methods can differ by the type and number of arguments, as well as the ref and out parameters.

        static void Function()                 // the 1st overload.   
        {
            Console.WriteLine("Hello!");
        }

        static void Function(string s)         // the 2nd overload.
        {
            Console.WriteLine(s);
        }

        static void Function(int i)            // the 3rd overload.
        {
            Console.WriteLine(i);
        }

        static void Function(double d)         // the 4th overload.
        {
            Console.WriteLine(d);
        }

        static void Function(string s, int i)  // the 5th overload.
        {
            Console.WriteLine(s + i);
        }

        static void Function(int i, string s)  // the 6th overload.
        {
            Console.WriteLine(i + s);
        }

        static void Function(ref int i, string s) // the 7th overload.
        {
            Console.WriteLine(i + s);
        }

        // Overloaded methods cannot differ by return values!
        //static string Function(string s)     // the 8th overload.              
        //{
        //    return s;
        //}

        // Overloaded methods cannot differ only by parameters ref and out!
        //static void Function(out int i, string s) 
        //{
        //    i = 5;
        //    Console.WriteLine(i + s);       // the 9th overload.
        //}
         
        static void Main()
        {
            Function();                  // the 1st overload. 
            Function("A");               // the 2nd overload.
            Function(1);                 // the 3rd overload.
            Function(3.14);              // the 4th overload.
            Function("B ", 2);           // the 5th overload.
            Function(3, " C");           // the 6th overload.
            
            int variable = 5;
            Function(ref variable, "D"); // the 7th overload.

            // Delay.
            Console.ReadKey();
        }
    }
}
