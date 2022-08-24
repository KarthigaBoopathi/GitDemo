using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    internal class prblm5
    {
        static void Main(string[] args)
        {
            Employees[] emp = { new Employees(),
                       new Employees(),
                       new Employees(), new Employees()};

            // Pass the array indexes with values as structures
            emp[0].SetEmployee(1, "Ojaswi", 20, 1);
            emp[1].SetEmployee(2, "Rohit", 21, 2);
            emp[2].SetEmployee(3, "Mohit", 23, 3);
            emp[3].SetEmployee(3, "Mohit", 23, 3);
            // Call the display method
            emp[0].DisplayEmployee();
            emp[1].DisplayEmployee();
            emp[2].DisplayEmployee();
            emp[3].DisplayEmployee();

        }
    }
    public struct Employees
    {

        // Declare three variables
        // id, name and age
        public int Id;
        public string Name;
        public int sal;
        public int depno;

        // Set the employee details
        public void SetEmployee(int id, string name, int salr, int depnos)
        {
            Id = id;
            Name = name;
            sal = salr;
            depno = depnos;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee:");
            Console.WriteLine("\tId    : " + Id);
            Console.WriteLine("\tName   : " + Name);
            Console.WriteLine("\tsal   : " + sal);
            Console.WriteLine("\tdepno  : " + depno);
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
