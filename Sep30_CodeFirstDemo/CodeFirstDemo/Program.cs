using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using CodeFirstDAL;

namespace CodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            context.StudentsTable.Add(new Student { Rollno = 1, Studname = "Karthiga", City = "Chennai", DOB = new DateTime(2022, 12, 11) });
            context.SaveChanges();
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
