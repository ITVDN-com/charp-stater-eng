using System;

// Display in binary format of a number that is passed in decimal one

namespace BinaryDigit
{
    class Program
    {
        static void Converter(int n)
        {
            int temp;

            temp = n % 2;
            
            if (n >= 2)
                Converter(n / 2);

            Console.Write(temp);
        }

        static void Main()
        {
            int n = 255;

            Converter(n);

            Console.ReadKey();
        }
    }
}
