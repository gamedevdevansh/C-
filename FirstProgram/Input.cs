using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class Input
    {
        public static void Test()
        {
            // Input = Getting data from the user.
            // Console.ReadLine() = method that allows us to read input from the user as a string.

            Console.WriteLine("What is your name? ");
            String name = Console.ReadLine();


            Console.WriteLine("What is your Age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("You're " + age + " years old.");
            Console.ReadKey();
        }
    }
}
