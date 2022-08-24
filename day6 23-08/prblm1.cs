using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    internal class prblm1
    {
        static void Main(string[] args)
        {
            add x = new add();

            x.sum(10, 90);
        }
    }
    class add
    {
        public void sum(int a, int b)
        {
            Console.WriteLine("SUM = " + (a + b));
            Console.ReadLine();
        }

    }
}
