using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace _5_9_demo
{
    public class Book
    {
        private int bid;
        public int Bookid
        {
            get { return bid; }
            set { bid = value; }
        }

        private string bname;
        public string Bookname
        {
            get { return bname; }
            set { bname = value; }
        }

        private int bprice;
        public int Bookprice
        {
            get { return bprice; }
            set
            {
                bprice = value;
            }
        }

        private string bauthor;
        public string Bookauthor
        {
            get { return bauthor; }
            set
            {
                bauthor = value;
            }
        }

        public Book() { }
        public Book(int id, string name, int price, string author)
        {
        }
        //method InsertBook(bookid, bookname, price)
        public void InsertBook(int id, string name, int price)
        {
            this.bid = id;
            this.bname = name;
            this.bprice = price;
        }
        //method InsertBook(bookid, bookname, price, author)
        public void InsertBook(int id, string name, int price, string author)
        {
            this.bid = id;
            this.bname = name;
            this.bprice = price;
            this.bauthor = author;
        }
        //InsertBook(bookid, bookname)
        public void InsertBook(int id, string name)
        {
            this.bid = id;
            this.bname = name;
        }
    }
    public class Novel : Book
    {
        int NoOfPages;
        public void InsertBook(int id, string name, int price, int noofpages)
        {
            this.Bookid = id;
            this.Bookname = name;
            this.Bookprice = price;
            this.NoOfPages = noofpages;
        }
        public class BookCategory
        {
            //catid,catname and description

            private int _catid;
            public int CatID
            {
                get { return _catid; }
                set { _catid = value; }
            }
            private string _catname;

            public string CatName
            {
                get { return _catname; }
                set { _catname = value; }
            }

            private string _desc;
            public string Description
            {
                get { return _desc; }
                set { _desc = value; }
            }
            public BookCategory() { }
            public BookCategory(int cid, string cname, string desc)
            {

            }
        }
        public class Cart:Book
        {
            //customerid,bookid,price as properties
            private int _customerid;

            public int CustomerID
            {
                get { return _customerid; }
                set { _customerid = value; }
            }
            private int _bookid;

            public new int Bookid
            {
                get { return _bookid; }
                set { _bookid = value; }
            }
            private int _price;

            public int Price
            {
                get { return _price; }
                set { _price = value; }
            }
            public void AddToCart(int customerid, int bookid, int price)
            {
                this.CustomerID = customerid;
                this.Bookid = bookid;
                this.Price = price;
            }
            int _bid, _p;
            private string _bname;
            public static List<Book> BookList = new List<Book>();
            public void DisplayBook()
            {
                _bid = base.Bookid;
                _bname = base.Bookname;
                _p = base.Bookprice;
                Console.WriteLine(_bid);
                Console.WriteLine(_bname);
                Console.WriteLine(_p);
            }
            public void AcceptData()
            {
                Book p = new Book();

                Console.WriteLine("Enter Book ID: ");
                p.Bookid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Book Name: ");
                p.Bookname = Console.ReadLine();

                Console.WriteLine("Enter Book Price: ");
                p.Bookprice = Convert.ToInt32(Console.ReadLine());

                InsertBook(p);
                Console.WriteLine("Book added successfully...");
            }
            public void InsertBook(Book BookData)
            {
                BookList.Add(BookData);
            }
            public List<Book> BooksList()
            {
                return BookList;
            }
            static int count;
            public void BookCount()
            {
                count = count + 1;
                Console.WriteLine("You added total Nos of Books: " + count);
            }
        }
    }
}
