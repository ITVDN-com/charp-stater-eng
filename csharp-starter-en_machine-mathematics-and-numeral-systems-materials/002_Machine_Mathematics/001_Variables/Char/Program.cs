using System;

namespace Char
{
    class Program
    {
        static void Main()
        {
            char a = 'A';      // Symbol
            char b = '\x0061'; // Value in hex format
            char c = '\u0041'; // Value in unicode format

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
