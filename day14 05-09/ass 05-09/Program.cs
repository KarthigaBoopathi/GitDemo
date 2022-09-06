using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5_9_demo;
using static _5_9_demo.Novel;

namespace ass_05_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart c = new Cart();
            c.AcceptData();
            c.AcceptData();
            List<Book> Blist = new List<Book>();
            Blist = c.BooksList();

            foreach (var i in Blist)
            {
                Console.WriteLine("Book ID: " + i.Bookid);
                Console.WriteLine("Book Name: " + i.Bookname);
                Console.WriteLine("Book Price: " + i.Bookprice);
                c.BookCount();
            }
            Console.ReadLine();
        }


    }
    }

