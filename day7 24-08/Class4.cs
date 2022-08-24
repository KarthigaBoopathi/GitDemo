using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class Class4
    {
        public static void Splits()
        {
            string text = "a b,c.d/e";
            Console.WriteLine("splitting " + text);

            string[] result = text.Split(' ', ',', '.', '/');

            foreach (string str in result)
            {
                Console.WriteLine(str);
                Console.ReadLine();
            }
        }
    }
}
