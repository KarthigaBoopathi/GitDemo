using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_25_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                do
                {

                    Console.WriteLine("1.to create\n 2.to add\n 3.to truncate\n");
                    int x = Convert.ToInt32(Console.ReadLine());
                    string path =@"C:\\Users\\Karthiga\\source\\repos\\Assignment day3_1";
                    Console.WriteLine("Enter the file name");
                    string fname = Console.ReadLine();


                    fname = string.Concat(path, fname);
                    Console.WriteLine("--------------------------------");
                    // file creation path
                    switch (x)
                    {
                        case 1:
                            // to create
                            FileStream f = new FileStream(fname, FileMode.Create);
                            StreamWriter s = new StreamWriter(f);

                            s.WriteLine("Hello!!");
                            s.Close();
                            f.Close();
                            Console.WriteLine("File created successfully...");
                            Console.ReadLine();
                            break;

                        case 2:
                            // to append
                            Console.WriteLine("-----------------");

                            FileStream fs = new FileStream(fname, FileMode.Append);
                            StreamWriter ss = new StreamWriter(fs);

                            ss.WriteLine("Welcomee..!!");
                            ss.Close();
                            fs.Close();
                            Console.WriteLine("Appended Successfully...");
                            Console.ReadLine();
                            break;

                        case 3:
                            // to truncate

                            Console.WriteLine("-----------------------");
                            FileStream fs1 = new FileStream(fname, FileMode.Truncate);
                            StreamWriter ss1 = new StreamWriter(fs1);

                            ss1.WriteLine("Hearty Congratulations!!");
                            ss1.Close();
                            fs1.Close();
                            Console.WriteLine(" truncate  successfully...");
                            Console.ReadLine();
                            break;



                    }
                } while (true);

            }
        }
    }
}
