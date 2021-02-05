using System;

// Simlified loop Spider.  

namespace Loop
{
    class Program
    {
        static void Main()
        {
            char character = '\0';            

            for (; ; )
            {
                character = Console.ReadKey().KeyChar;

                switch (character)
                {
                    case 'l': // 'l' - guard condition 1.
                        {
                            Console.WriteLine("Go left"); continue; // guarded instruction.
                        }
                    case 'r': // 'r' - guard condition 2.
                        {
                            Console.WriteLine("Go right"); continue; // guarded instruction.
                        }
                }

                switch (character)
                {
                    case 'x': // 'x' - exit condition 1.
                        {
                            Console.WriteLine("Exit"); break; // exit instruction.
                        }
                    case 'q': // 'q' - exit condition 2.
                        {
                            Console.WriteLine("Quit"); break; // exit instruction.
                        }
                    default: // Branch of alternative exit.
                        {
                            Console.WriteLine("Alternative exit"); break;
                        }
                }
                                
                break;  // Break of a loop.
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
