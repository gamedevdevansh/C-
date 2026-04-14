using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class Variables
    {
        public static void Test()
        {
            int a; // declaration of variable a.
            a = 10; // initialization of variable a.
            int b = 20; // declaration and initialization of variable b.
            int c = a + b;
            int age = 22; // whole integer number.
            double weight = 76.50; // decimal number with double precision. (15-16 digits after decimal point)
            float height = 5.8f; // decimal number with single precision. (6-7 digits after decimal point)
            bool alive = true; // boolean value can be either true or false.
            char symbol = '@'; // character value should be enclosed in single quotes.
            String name = "Dev"; // string value should be enclosed in double quotes. String is a sequence of characters.
            Console.WriteLine("You're Alive: " + alive);
            Console.WriteLine("Symbol is : " + symbol);
            Console.WriteLine("username is : " + name);
            Console.WriteLine("Your's Age is : " + age);
            Console.WriteLine("Your's Weight is : " + weight + "kgs");
            Console.WriteLine("Your's Height is : " + height + "ft");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //Constant = Immutable values which are known at compile time and do not change for the life of the program.

            //double pi = 3.14; // variable pi can be changed.

            const double pi = 3.14; // constant Pi cannot be changed.

            //pi = 3300; // This is valid as pi is a variable.

            Console.WriteLine("Value of pi: " + pi);

            Console.ReadKey();
        }

    }
}
