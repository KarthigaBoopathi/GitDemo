using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using access_specifiers;

namespace ass_06_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //q1
            /*  person p;
               p = new employees();
               p.work();
               p = new manager();
               p.work();
               p = new clerk();
               p.work(); 

               //q2

               bank b1 = new bank();
               b1.print_balance();
               b1.calc_interest(); 

               //q3,4

               Console.WriteLine("savings account");
               banks b = new savings();
               b.print_balance();
               b.calc_interest();
               Console.WriteLine("current aacount");
               banks b2 = new current();
               b2.print_balance();
               b2.calc_interest(); */

            //q5,6
            Console.WriteLine("Amount Depsoits and Withdrawl------");
            banks b3 = new banks();
            b3.current();
            b3.savings();
            b3.deposits();
            b3.withdraw();
            b3.total_balc();
            b3.deposits1();
            b3.withdraw1();
            b3.total_balc1();
            Console.ReadLine();
            

           
            

        }
    }

    } 
    


            
        
    


