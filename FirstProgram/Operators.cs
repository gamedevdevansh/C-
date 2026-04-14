using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class Operators
    {
        public static void Test()
        {
            // Operators = symbols that perform operations on variables and values.
            // Types of operators:
            // 1. Arithmetic Operators
            // 2. Assignment Operators
            // 3. Comparison Operators
            // 4. Logical Operators
            // 5. Bitwise Operators
            // 6. Misc Operators
            // Arithmetic Operators = used to perform mathematical operations.

            int friends = 5;

            friends = friends + 1;
            //friends += 1;
            //friends++;
            Console.WriteLine(friends);

            friends = friends - 1;
            //friends -= 1;
            //friends--;
            Console.WriteLine(friends);

            friends = friends * 2;
            //friends *= 2;
            Console.WriteLine(friends);

            friends = friends/2;
            //friends /= 2;
            Console.WriteLine(friends);

            int remainder = friends % 3;
            Console.WriteLine(remainder);

            Console.ReadKey();
        }
    }
}
