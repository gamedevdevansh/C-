using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class Maths
    {
        public static void Test()
        {
            // Math class = a class that contains methods for performing mathematical operations.
            // Math.Sqrt() = method that returns the square root of a number.
            // Math.Pow() = method that returns a number raised to the power of another number.
            // Math.Abs() = method that returns the absolute value of a number.
            // Math.Max() = method that returns the larger of two numbers.
            // Math.Min() = method that returns the smaller of two numbers.
            // Math.Floor() = 
            // Math.Round() =
            // Math.Ceiling() =

            double x = -3.555;
            double y = 9;

            double a = Math.Pow(x, 2);
            double b = Math.Sqrt(y);
            double c = Math.Abs(x);
            double d = Math.Floor(x);
            double e = Math.Ceiling(x);
            double f = Math.Round(x);
            double g = Math.Max(x,y);
            double h = Math.Min(x,y);
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            

            Console.ReadKey();
        }
    }
}
