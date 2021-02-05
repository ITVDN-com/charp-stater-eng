using System;

namespace Methods
{
    class Program
    {
        static void Add( int x,  int y, out int sum)
        {
            sum = x + y;
        }

        static void Main()
        {
            Console.WriteLine("Enter the 1-st number.");
            
            string operand1 = Console.ReadLine();
            int summand1 = Int32.Parse(operand1);

            Console.WriteLine("Enter the 2-nd number.");
           
            string operand2 = Console.ReadLine();
            int summand2 = Int32.Parse(operand2);
                       
            int sum;

            Add( summand1, summand2, out sum);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            // Delay.
            Console.ReadKey();
        }
    }
}
