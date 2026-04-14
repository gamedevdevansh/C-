using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram{
    internal class Statements{
        public static void Test()
        {

            //if statemnet = a basic programming statement that performs a specific action based on a condition.

            //Console.WriteLine("Please enter your name: ");
            //String name = Console.ReadLine();

            //if (name == null)
            //{
            //    Console.WriteLine("You did not enter your name.");
            //}
            //else
            //{
            //    Console.WriteLine("Hello " + name);
            //}


            //switch statement an efficeint alternative to many if else Statements.Test

            Console.WriteLine("What day is it Today?");
            String day = Console.ReadLine();

            switch (day){
                case "Monday":
                    Console.WriteLine("It's Monday.");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday.");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday.");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday.");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday.");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday.");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday.");
                    break;
                default:
                    Console.WriteLine(day + " is not a day.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
