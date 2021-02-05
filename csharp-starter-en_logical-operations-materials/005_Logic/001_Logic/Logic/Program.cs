using System;

// Bitwise logical statements.

namespace Logic
{
    class Program
    {
        static void Main()
        {
            byte operand1 = 0, operand2 = 0;
            int result;

            #region Conjunction

            // The truth table for the operations of conjunction - & - [AND]  

            // If one of the operands is 0 - the whole structure is 0. Otherwise - 1

            //    0 & 0 = 0         1 & 0 = 0
            //    0 & 1 = 0         1 & 1 = 1

            operand1 = 0xFF;                         // [1111 1111 Bin] = [FF Hex] = [255 Dec]            
            operand2 = 0x01;                         // [0000 0001 Bin] = [01 Hex] = [01 Dec]
            result = operand1 & operand2;            // [0000 0001 Bin] = [01 Hex] = [01 Dec]

            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Disjunction

            // The truth table for disjunction - | - [OR] 

            // If one of the operands is 1 - the whole structure is 1. Otherwise - 0

            //    0 | 0 = 0         1 | 0 = 1
            //    0 | 1 = 1         1 | 1 = 1

            operand1 = 0x02;                          // [0000 0010 Bin] = [02 Hex] = [02 Dec]            
            operand2 = 0x01;                          // [0000 0001 Bin] = [01 Hex] = [01 Dec]
            result = operand1 | operand2;             // [0000 0011 Bin] = [03 Hex] = [03 Dec]

            Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Exclusive OR

            // The truth table for the exclusive OR - ^ - [XOR]

            // If the operands have the same value - the result is 0,
            // If the operands are different  1

            //    0 ^ 0 = 0         1 ^ 0 = 1
            //    1 ^ 1 = 0         0 ^ 1 = 1  

            operand1 = 0x03;                          // [0000 0011 Bin] = [03 Hex] = [03 Dec]            
            operand2 = 0x01;                          // [0000 0001 Bin] = [01 Hex] = [01 Dec]
            result = operand1 ^ operand2;             // [0000 0010 Bin] = [02 Hex] = [02 Dec]

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);

            #endregion
           
            #region Negation

            // The truth table for negation - ~ - [NOT]

            // ~ 0  = 1                               
            // ~ 1  = 0                                   

            operand1 = 0x01;         // [0000 0001] = [01 Dec]
            result = ~operand1;      // [1111 1110] = [-2 Dec]

            Console.WriteLine("NOT {0} = {1}", operand1, result);
            
            #endregion

            #region Change of sign

            // Formula of sign changing, from (+ N) to (-N) or vice versa.

            // To change the sign of a number, it is necessary:
            // to negate it and to increase it by 1.

            //  ~  +N + 1 = -N
            //  ~  -N + 1 = +N                      

            operand1 = 0x01;                            // [0000 0001]
            result = ~operand1;                         // [1111 1110]
            result++;                                   // [1111 1111]

            Console.WriteLine(" ~ {0} + 1 = {1} ", operand1, result);
            
            #endregion

            // Delay.
            Console.ReadKey();
        }
    }
}
