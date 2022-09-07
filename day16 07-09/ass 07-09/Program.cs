using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Delegatesdemo;


namespace ass_07_09
{
    internal class Program
    {
          public delegate string stren5(string spo, string spo1);
        static void Main(string[] args)
        {
            //q1
            Console.WriteLine("Enter the string");
            string m = Console.ReadLine();
            Concatenate s1 = new Concatenate();
            Concat s2 = new Concat(s1.lengthofstring);
            s2(m);
            
            //q2
            Console.WriteLine("Enter username");
            string g = Console.ReadLine();
            Concat s3 = new Concat(s1.greet);
            s3(g);
            
            
            //q3
            Console.WriteLine("Enter the two numbers");
            int n1= Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            integer i = new integer();
            Operations [] d3 = new Operations [3] { i.Add, i.Sub, i.Mul };
            Operations d4 = (Operations)MulticastDelegate.Combine(d3);
            d4(n1, n2);
            
            //q4
            Console.WriteLine("Enter productId and product name");
            Products p1 = new Products();
            p1.pid = Convert.ToInt32(Console.ReadLine());
            p1.name = Console.ReadLine();
            Desc p= new Desc(p1.Display);
            p(p1);

            //q5
            Employee emp = new Employee();
            Console.WriteLine("Enter the year,Month,date");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int date = Convert.ToInt32(Console.ReadLine());
            
            DateTime t = new DateTime(year, month, date);
            emp.Joining = t;
            EmpDetails e = new EmpDetails(emp.Expyrs);
            int e1 = e(emp.Joining);
            Console.WriteLine($"Years of exp {e1}");
     
            //q6
            Console.WriteLine("Enter two strings");
            string a1 = Console.ReadLine();
            string a2 = Console.ReadLine();
            stren5 c = delegate (string a, string b)
            {
                return a + b;
            };
            string d = c(a1, a2);
            Console.WriteLine($"Concatenated string is {d}");
            Console.ReadLine();

            
        }
    }
    }

