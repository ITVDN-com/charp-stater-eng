using System;

// Ternary conditional operator.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            double quantity = 10;    // Quantity of goods            
            double price = 100;      // Price per unit of goods.           
            double discount = 0.75;  // Discount on the total cost - 25%.
            double cost;             // Total cost.  

            // IF: 10 units or more are bought. THEN: give a 25% discount. ELSE: Do not give a discount.

            cost = quantity >= 10 ? quantity * price * discount : quantity * price;

            Console.WriteLine("The total cost of the goods is: {0} u.s.d.", cost);

            // Delay.
            Console.ReadKey();
        }
    }
}
