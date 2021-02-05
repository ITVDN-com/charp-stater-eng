using System;

// Logical statements.

namespace Logic
{
    class Program
    {
        static void Main()
        {
            bool operand1 = false, operand2 = false, result = false;

            #region Conjunction

            // The truth table for the operations of conjunction - && - [AND]

            // If any of the expression values of the conjunction operation is false -
            // the whole expression is false, otherwise - true

            // false && false = false                  true && false = false
            // false && true = false                   true && true = true

            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 && operand2;             // false

            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Disjunction

            // The truth table for disjunction - || - [OR]

            // If any of the expression values of disjunction operation has a value is true - 
            // the whole expression is true, otherwise - false

            // false || false = false                  true || false = true         
            // false || true = true                    true || true = true

            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 || operand2;             // true

            Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Exclusive OR

            // The truth table for the exclusive OR - ^ - [XOR]

            // If both expressions of exclusive OR operation have the same value -
            // the whole expression has a value of false, if different - true


            // false ^ false = false                   true ^ false = true
            // false ^ true = true                     true ^ true = false

            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 ^ operand2;              // true

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Negation

            // The truth table for negation (NOT) - ! - [NOT]

            // !false  = true
            // !true  = false       

            operand1 = true;
            result = !operand1;

            Console.WriteLine("NOT {0} = {1}", operand1, result);
            
            #endregion
                        
            // Delay.
            Console.ReadKey();
        }
    }
}
