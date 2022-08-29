using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_26_08
{
    internal class Class1
    {
        public struct Students
        {
            public int Id;
            public string Name;
            public int Fees;

            public void SetStudent(int id, string name, int fees)
            {
                Id = id;
                Name = name;
                Fees = fees;
            }
            public void gets()
            {
                Console.WriteLine("enter id");
                Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter name");
                Name = Console.ReadLine();
                Console.WriteLine("emter fees");
                Fees = Convert.ToInt32(Console.ReadLine());
            }
            public void PrintStudents()
            {
                Console.WriteLine("Student details:");
                Console.WriteLine("\tID: " + Id);
                Console.WriteLine("\tName: " + Name);
                Console.WriteLine("\tFees: " + Fees);
                Console.WriteLine("\n");
                Console.ReadLine();
            }
        }
    }
}
