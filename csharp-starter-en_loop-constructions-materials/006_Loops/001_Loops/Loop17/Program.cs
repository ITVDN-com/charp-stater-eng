using System;

// Loop Spider.  Modified Dijkstra's loop with explicit exit conditions.

// Dijkstra's loop does not include explicit conditions to continue or exit. 
// So a complicated construction of Dijkstra's loop, called "Loop Spider" was proposed. 

// In Dijkstra's notation it looks like this:

// do
//    P1→S1,
//      …
//    Pn→Sn
//  out
//    Q1→T1,
//      …
//    Qn→Tn
//  else
//    E
// od

// where:
// do — marker of loop beginning, 
// od — marker of loop end, 
// Pi — i-th guard condition (Boolean expression that can have a value of "true" or "false"), 
// Si — i-я guarded instruction.  
// After the marker out branches of completion, consisting of exit conditions Qi and exit instructions Ti are added. 
// In addition, a branch of alternative exit with the instruction E is added.

//   Loop 'Spider' is executed as follows:
//   Guard conditions are calculated. 
//   If there is truth guard condition, the appropriate guarded instruction is performed.
//   Exit conditions are calculated. 
//   If there is a true exit condition, the appropriate esit instruction is performed,
//   then the loop is ended.
//   If all exit conditions are false, the next iteration starts, but only if in the current iteration
//   at least one of guard conditions was true.
//   If in the current iteration all guard conditions and all exit conditions are false,   
//   an instruction of alternative exit E is performed, then the loop is broken.

namespace Loop
{
    class Program
    {
        static void Main()
        {
            char character = '\0';
            
            bool flag = default(bool);

            for (; ; )
            {
            Start:
                flag = false;
                character = Console.ReadKey().KeyChar;

                switch (character)
                {
                    case 'l': // 'l' - guard condition 1.
                        {
                            Console.WriteLine("Go left"); flag = true; break; // guarded instruction.
                        }
                    case 'r': // 'r' - guard condition 2.
                        {
                            Console.WriteLine("Go right"); flag = true; break; // guarded instruction.
                        }
                }

                switch (character)
                {
                    case 'x': // 'x' - exit condition 1.
                        {
                            Console.WriteLine("Exit"); goto End; // exit instruction.
                        }
                    case 'q': // 'q' - exit condition 2.
                        {
                            Console.WriteLine("Quit"); goto End; // exit instruction.
                        }
                }

                // Branch of alternative exit.
                if (flag)
                {
                    goto Start;
                }

                Console.WriteLine("Alternative exit");

            End:
                break;  // Break of a loop.
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
