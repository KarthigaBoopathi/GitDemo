using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_25_08
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            //to create file
            string path = @"C:\\Users\\Karthiga\\source\\repos\\day6";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();
            fname = string.Concat(path, fname);
            //File.Create(path+fname);
            Console.WriteLine("file created successfully...");
            Console.ReadLine();

            //to add contents to file

            /*Console.WriteLine("Enter your file contents");
              string content = Console.ReadLine();
              File.WriteAllText(fname, content);
              Console.WriteLine("file created successfully with contents...");  */

            //copy the file

            /*  File.Copy(fname, "C:\\Users\\Karthiga\\source\\repos\\day6\\democopy.txt");
              Console.WriteLine("copy succesfully");  */

            //to move the file
            /* File.Move(fname, "C:\\Users\\Karthiga\\source\\repos\\day6\\MovedFile.txt");
               Console.WriteLine("File Moved Succesfully");   */

            //to delete the file
            /* File.Delete(fname); */   

            FileInfo fileInfo = new FileInfo(fname);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(fileInfo.FullName + "  Full Name");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(fileInfo.Extension + " Extension");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(fileInfo.DirectoryName + " DirectoryName");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(fileInfo.CreationTime);

        }
    }
}
