using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram{
    internal class Statements{
        public static void Test()
        {

            //if statemnet = a basic programming statement that performs a specific action based on a condition.

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name == null)
            {
                Console.WriteLine("You did not enter your name.");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }

            Console.ReadKey();
        }
    }
}
