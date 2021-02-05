using System;

// "Casting" or "Type conversion" is a conversion of a variable value from one type to another.
// There are two different kinds of casting: explicit and implicit.

namespace Casting
{
    class Program
    {
        static void Main()
        {
            //   ----------------------------------  Variables  ---------------------------------------------

            #region Implicit (safe) casting:

            // Implicit Type Conversion (safe) is a conversion of a value of smaller type to a value of a greater type.
            byte a = 10;     //                                      0000 1010  -  1 byte.
            int b = 0;       //  0000 0000   0000 0000   0000 0000   0000 0000  -  4 bytes.
            b = a;           //  0000 0000   0000 0000   0000 0000   0000 1010  -  4 bytes.              

            Console.WriteLine(b);

            // Implicit Type Conversion (safe) is a conversion of a value of an integer type to a real type.
            int c = 255;     //  0000 0000   0000 0000   0000 0000   1111 1111  -  4 bytes.
            float d = 0f;
            d = c;

            Console.WriteLine(d);

            #endregion

            #region Explicit (unsafe) casting:

            // Explicit Type Conversion (unsafe) is a conversion of a value of a greater type to a value of a smaller type .
            int e = 256;     //  0000 0000   0000 0000   0000 0001   0000 0000  -  4 bytes.
            byte f = 0;      //                                      0000 0000  -  1 byte.
            f = (byte)e;     //                                      0000 0000  -  1 byte.
            //f = e;        //  ERROR.

            Console.WriteLine(f);

            // Explicit Type Conversion (unsafe) is a conversion of a value of a real type to an integer type.
            float g = 10.5F;
            int h = 0;
            h = (int)g;
            //h = g;         // ERROR.

            Console.WriteLine(h);

            #endregion

            //   ----------------------------------  Constants  ----------------------------------------------

            #region Constant casting.

            // Implicit casting of a constant value from type "int" to type "byte",
            // during initialization of a variable with constant value 
            // if the constant value doesn't exceed the maximum possible value of a variable it is possible.


            const int i = 255;  //  0000 0000   0000 0000   0000 0000   1111 1111  -  4 bytes.
            byte j = 0;         //                                      0000 0000  -  1 byte.
            j = i;              //                                      1111 1111  -  1 byte.

            Console.WriteLine(j);

            // Explicit casting of constant value from a "float" type  to a "byte" type 
            // during initialization of a variable with a constant value 
            // if the constant value doesn't exceed the maximum possible value of a variable it is possible.

            const float k = 255;
            byte l = 0;
            l = (byte)k;

            Console.WriteLine(l);


            // Either implicit and explicit casting of constant value  
            // during initialization of variable with a constant value 
            // if the constant value exceeds the maximum possible value of a variable it is impossible.

            const int m = 256;  //  0000 0000   0000 0000   0000 0001   0000 0000  -  4 byte.
            byte n = 0;         //                                      0000 0000  -  1 byte.
            // n = m;           //  ERROR.
            // n = (byte)m;     //  ERROR.

            Console.WriteLine(n);

            // Either implicit and explicit casting of a constant real value  
            // during initialization of an integer variable with a constant value 
            // if the constant value exceeds the maximum possible value of a variable it is impossible..

            const float o = (float)256.5;
            byte p = 0;
            // p = o;           //  ERROR.
            // p = (byte)o;     //  ERROR.

            Console.WriteLine(p);

            #endregion

            // Delay.
            Console.ReadKey();
        }
    }
}
