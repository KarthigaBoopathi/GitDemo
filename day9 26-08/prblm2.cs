using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_26_08_qn3
{
    internal class Class1
    {
        public class Class_stud
        {
            public int id;
            public string Name;
            public int Age;


            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public string SName
            {
                get { return Name; }
                set { Name = value; }
            }
            public int age
            {
                get { return Age; }
                set { Age = value; }
            }

        }
        static void Main(string[] args)
        {
            // student[] s = new student[2];
            Class_stud[] s = new Class_stud[1];
            for (int i = 0; i < s.Length; i++)
            {
                // s[i] = new student();
                s[i] = new Class_stud();

                Console.WriteLine("Enter id:");
                s[i].Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                s[i].SName = Console.ReadLine();
                Console.WriteLine("Enter Age:");
                s[i].age = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in s)
            {
                Console.WriteLine("Details");
                Console.WriteLine(item.Id);
                Console.WriteLine(item.SName);
                Console.WriteLine(item.age);
                Console.ReadLine();


            }

        }
    }
}
