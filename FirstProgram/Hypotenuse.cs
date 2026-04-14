using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class Hypotenuse
    {
        public static void Test()
        {
            Console.WriteLine("Enter Side A:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Side B:");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("The Hypotenuse is: " + c);

            Console.ReadKey();
            //Console.ReadKey();
        }
    }
}
