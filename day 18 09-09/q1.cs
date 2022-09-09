using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ass_09_09
{
    class Program
    {
        public static void method1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method 1 =   {0} ", i);
                if (i == 3)
                {
                    Thread.Sleep(3000);
                }
            }
        }
        public static void method2()
        {
            for (int j = 0; j <= 3; j++)
            {
                Console.WriteLine("Method 2 =   {0} ", j);

            }

        }
        public static void method3()
        {
            Console.WriteLine("Method3");
        }

        static void Main(string[] args)
        {
            //M1();
            //M2();
            Thread t1 = new Thread(method1);
            Thread t2 = new Thread(method2);
            Thread t3 = new Thread(method3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.Read();

        }
    }
}
