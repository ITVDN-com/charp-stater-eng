using System;
 //Use of local areas and local variables.


namespace LocalVariables
{
    class Program
    {
        static void Main()
        {
            // RULE:
            //In a code, you can create a local area and in two different local areas you can store two variables with the same name.
           
                        
            // Local area 1
            {
                int a = 1;
                Console.WriteLine(a);
            }

            // Local area 2
            {
                int a = 2;
                Console.WriteLine(a);
            }

            
            // Rule:
            //If you have a local area code, it is forbidden to store variables with the same name INSIDE the local areas.

            //int a = 3; //  ERROR: A variable with the same name already exists in the local area
                        

            // Delay.
            Console.ReadKey();
        }
    }
}
