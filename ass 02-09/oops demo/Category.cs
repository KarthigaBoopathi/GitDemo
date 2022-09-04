using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_demo
{
    public class Category
    {
        private int categoryid;
        public int ID
        {
            get { return categoryid; }
            set { categoryid = value; }
        }
        private string categoryname;
        public string Name
        {
            get { return categoryname; }
            set { categoryname = value; }
        }
        private string description;
        public string Desc
        {
            get { return description; }
            set { description = value; }

        }
        public List<Products> product;
        public List<Products> prod
        {
            get { return product; }
            set
            {
                product = value;
            }
        }
        static int cnt = 0;
        public void AddProdut()
        {
            cnt++;
            Console.WriteLine("Product added {0}", cnt);
        }
        public void DeleteProduct()
        {
            cnt--;
            Console.WriteLine("Product added {0}", cnt);
        }
        public Category()
        {

        }
        public void AddCategory(int id, string name, string desc)
        {
            categoryid = id;
            categoryname = name;
            description = desc;
        }
        public void Display()
        {
            Console.WriteLine(categoryid);
            Console.WriteLine(categoryname);
            Console.WriteLine(description);
            foreach (var item in product)
            {
                Console.WriteLine(item.Productid);
                Console.WriteLine(item.Productname);

            }
        }

    }
    public class Products
    {
        private int productid;
        public int Productid
        {
            get { return productid; }
            set { productid = value; }
        }
        private string prodname;
        public string Productname
        {
            get { return prodname; }
            set { prodname = value; }
        }
        private int qtySold;
        public int Qtysold
        {
            get { return qtySold; }
            set { qtySold = value; }
        }

        private int unitprice;
        public int Unitprice
        {
            get { return unitprice; }
            set
            {
                unitprice = value;
            }
        }

        private string unitofmeas;
        public string UnitOfMeasurement
        {
            get { return unitofmeas; }
            set
            {
                unitofmeas = value;
            }
        }
        private int QtyInhand;
        public int QuanInhand
        {
            get { return QtyInhand; }
            set
            {
                QtyInhand = value;
            }
        }
        
        

        public void ReorderLevel()
        {
            int reorder;
            reorder = qtySold;

        }
        public void AddProduct(int id, string name)
        {
            productid = id;
            prodname = name;

        }

    }



    }

