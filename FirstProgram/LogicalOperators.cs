using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class LogicalOperators
    {
        public static void Test() {
            // Logical operators = used to determine the logic between variables or values.
            // can be used to check if more than 1 condition is true or false.

            // && (AND) operator = both conditions must be true for the entire expression to be true.
            // || (OR) operator = at least one condition must be true for the entire expression to be true.

            Console.WriteLine("What's the Temprature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if(temp >= 10 && temp <= 25)
            {
                Console.WriteLine("it's warm outside!");
            } else if(temp <= -50 || temp >= 50)
            {
                Console.WriteLine("Don't Go OUTSIDE!");
            }

            Console.ReadKey();
        }
    }
}
