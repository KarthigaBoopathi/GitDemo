using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class Class5
    {
        public static void uppercase()
        {
            string s1, s2;
            Console.WriteLine("Enter the string");
            s1=Console.ReadLine();
            s2=s1.ToUpper();
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
