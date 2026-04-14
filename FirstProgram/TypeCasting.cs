using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class TypeCasting
    {
        public static void Test()
        {
            // Type casting = Converting a variable from one type to another type.
            // useful when we accept user input(String)
            // Different data types can do different things. For example,
            // we can do mathematical operations with integers and doubles,
            // but we cannot do mathematical operations with strings.
            // So, if we want to do mathematical operations with user input,
            // we need to convert the string input to a numeric type.

            double a = 3.14; 
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;    
            String f = Convert.ToString(e);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());
            Console.WriteLine(h);
            Console.WriteLine(h.GetType());
            Console.WriteLine(j);
            Console.WriteLine(j.GetType());
        }
    }
}
