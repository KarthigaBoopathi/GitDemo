using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    internal class prblm2
    {
        static void Main(string[] args)
        {

            method x = new method ();

            int result = x.sums(50, 20);
            Console.WriteLine("sum" + " " + result);
            Console.ReadLine();
        }
    }

    class method
    {
        public int sums(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
}
