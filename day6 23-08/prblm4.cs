using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    internal class prblm4
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.getdata();
            obj.ShowData();
        }
    }
    public struct Employee
    {
        public int EmpID;
        public string empName;
        public int sal;
        public int deptno;

        public Employee(int ID, string name, int salary, int dep)
        {
            EmpID = ID;
            empName = name;
            sal = salary;
            deptno = dep;
        }
        public void getdata()
        {
            Console.WriteLine("enter the emid");
            EmpID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the enpname");
            empName = Console.ReadLine();
            Console.WriteLine("enter the sal");
            sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the depno");
            deptno = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowData()
        {
            Console.WriteLine("Employee ID=" + EmpID);
            Console.WriteLine("Employee Name=" + empName);
            Console.WriteLine("Employee sal=" + sal);
            Console.WriteLine("Employee dep.no.=" + deptno);
            Console.ReadLine();

        }
    }
}
