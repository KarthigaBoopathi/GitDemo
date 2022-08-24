using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class Class1
    {
        public static void print()
        {
            string s1, s2;
            Console.WriteLine("Enter first string");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            s2 = Console.ReadLine();
            if (s1.Equals(s2))
            {
                Console.WriteLine("String is equal");
            }
            else
            {
                Console.WriteLine("String is not equal");
            }

            Console.ReadLine();
        }
        

    }
}
