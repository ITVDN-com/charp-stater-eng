using System;

// Dijkstra's loop.

// When Dijkstra's loop the calculation of guard conditions is taking place in each iteration. 
// If at least one of them is true, the appropriate guarded instruction is performed, followed by a new iteration 
// (if several guard conditions are true, only one guarded instruction is executed).
// If all guard conditions are false, the loop is over. 
// Dijkstra's loop with one guard condition and one guarded instruction is, in fact, a common loop with a precondition (loop «while»).

// The classical description of Dijkstra's loop.
// do
//   P1 → S1,
//     …
//   Pn → Sn
// od

// where:
// do — marker of loop beginning, 
// od — marker of loop end, 
// Pi — i-the guard condition (Boolean expression that can have a value of "true" or "false"), 
// Si — i- guarded instruction. 

// Loop consists of one or more branches (guard expressions)
// each of which is a pair of guard condition and guarded instruction.  

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
                            Console.WriteLine("Go left");    // guarded instruction.
                           continue; 
                        }
                    case 'r': // 'r' - guard condition 2.
                        {
                            Console.WriteLine("Go right");   // guarded instruction.
                            continue;
                        }
                }
                break;  // breaking of loop.
            }

            // Delay.
            // Console.ReadKey();
        }
    }
}
