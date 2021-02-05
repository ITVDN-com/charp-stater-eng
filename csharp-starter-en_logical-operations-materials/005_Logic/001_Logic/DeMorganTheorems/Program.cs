using System;

/*
 * Conversion of logical variables according to the theorem of De Morgan.
 * 
 * To use De Morgan's theorems in the logical operators AND or OR, and a pair of operands,
 * we need to invert two operands, replace (AND for OR) or (OR for AND) and
 * invert all statement completely.
 * 
 *  the source statement                        equivalent statement
 *     !A & !B                       =                  !(A | B)
 *     !A & B                        =                  !(A | !B)
 *     A & !B                        =                  !(!A | B)   
 *     A & B                         =                  !(!A | !B)
 *     !A | !B                       =                  !(A & B)
 *     !A | B                        =                  !(A & !B)
 *     A | !B                        =                  !(!A & B) 
 *     A | B                         =                  !(!A & !B)    
 */

//The negation of a conjunction is the disjunction of the negations.
//The negation of a disjunction is the conjunction of the negations
namespace DeMorganTheorems
{
    class Program
    {
        static void Main()
        {
            bool A = true;
            bool B = false;

            // Condition before applying De Morgan's theorem.
            Console.WriteLine("!A || !B = {0}", !A || !B);

            // Condition after applying De Morgan's theorem.
            Console.WriteLine("!(A && B) = {0}", !(A && B));

            // Delay.
            Console.ReadKey();
        }
    }
}
