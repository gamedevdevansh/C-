using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram{
    internal class RandomNum{
        public static void Test() { 
            Random random = new Random();

            int num1 = random.Next(1, 11); // generates a random number between 1 and 10
            int num2 = random.Next(1, 11); // generates a random number between 1 and 100
            int num3 = random.Next(1, 11); // generates a random number between 1 and 1000

            double num = random.NextDouble(); // generates a random number between 0.0 and 1.0

            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();
        }
    }
}
