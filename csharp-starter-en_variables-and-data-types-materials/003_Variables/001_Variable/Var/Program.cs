using System;

// Implicitly Typed Local Variables.

namespace Var
{
    class Program
    {
        static void Main()
        {
            // Implicitly Typed Local Variable - myVar.
            var myVar = 7;

            Console.WriteLine(myVar);

            // Implicitly Typed Local Variables do not allow multiple declarations.
            // var a = 1, b = 2, c = 3;  // Error.

            // Implicitly Typed Local Variables have to be initialized.
            // var a; // Error.

            // Constants can't be Implicitly Typed Local.
            // const var myVar = 3.14; 

            // Delay.
            Console.ReadKey();
        }
    }
}
