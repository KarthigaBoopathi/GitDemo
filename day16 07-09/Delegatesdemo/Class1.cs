using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatesdemo
{
    public delegate void Concat(string s);
    public delegate void Operations(int i, int j);
    public delegate void Desc(Products p);
    public delegate int EmpDetails(DateTime t);
    public delegate void Uppercase();


    public class Concatenate
    {
        public void lengthofstring(string s)
        {
            Console.WriteLine(s.Length);

        }
        public void greet(string s)
        {
            Console.WriteLine($"Hello {s}");
        }
    }
    public class integer
    {
        public void Add(int i, int j)
        {
            Console.WriteLine($"Addition is {i + j}");
        }
        public void Sub(int i, int j)
        {
            if (i > j)
            {
                Console.WriteLine($"Subtraction is {i - j}");
            }
            else
            {
                Console.WriteLine($"Subtraction is {j - i}");
            }
        }
        public void Mul(int i, int j)
        {
            Console.WriteLine($"Multiplication is {j * i}");
        }

    }
    public class Products
    {
        public int pid
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public void Display(Products p)
        {
            Console.WriteLine($"Product id is {p.pid} and name is {p.name}");
        }
    }
    public class Employee
    {
        private DateTime _joining;
        public DateTime Joining
        {
            get { return _joining; }
            set { _joining = value; }

        }
        public int Expyrs(DateTime ji)
        {
            int p = DateTime.Now.Year - ji.Year;
            return p;
        }
    }


    public class convert
    {
       
            static void Main()
            {
                string str = "welcome";

                if (str.Length == 0)
                    System.Console.WriteLine("Empty String");
                else if (str.Length == 1)
                    System.Console.WriteLine(char.ToUpper(str[0]));
                else
                    System.Console.WriteLine(char.ToUpper(str[0]) + str.Substring(1));
            }
        }
    }




       




