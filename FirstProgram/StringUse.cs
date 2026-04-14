using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class StringUse
    {
        public static void Test()
        {
            // String = a data type that represents a sequence of characters.
            // Strings are immutable = cannot be changed after they are created.
            // String concatenation = the process of combining strings.

            String fullName = "Devansh Verma";
            String phoneNumber = "123-456-7890";

            fullName = fullName.ToUpper(); // converts the string to uppercase
            Console.WriteLine(fullName);
            fullName = fullName.ToLower(); // converts the string to lowercase
            Console.WriteLine(fullName);

            phoneNumber = phoneNumber.Replace("-", ""); // replaces the hyphens with spaces
            Console.WriteLine(phoneNumber);


            String userName = fullName.Insert(0, "Mr. "); // inserts a string at a specified index
            Console.WriteLine(userName);

            Console.WriteLine(fullName.Length); // returns the length of the string

            String firstName = fullName.Substring(0, 7); // returns a substring of the string
            String lastName = fullName.Substring(7).Trim(); // returns a substring of the string

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            Console.ReadKey();
        }
    }
}
