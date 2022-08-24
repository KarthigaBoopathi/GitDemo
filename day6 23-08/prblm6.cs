using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_handson
{
    internal class qstn6
    {
        static void Main(string[] args)
        {
           Console.WriteLine("department of purchase=" + (int)Deptname.purchase);
           Console.WriteLine("department of sales=" + (int)Deptname.sales);
           Console.WriteLine("department of training=" + (int)Deptname.training);
           Console.WriteLine("department of account=" + (int)Deptname.account);
           Console.ReadLine();
        }
        enum Deptname
        {
            purchase = 1,
            sales,
            training,
            account

        }
    }
}