using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private int productid;
        public int ID
        {
            get { return productid; }
            set { if (productid == null)
                    throw new Exception("Please Enter correct value");
                else { productid = value; }
                        }
        }

        private string productname;
        public string Name
        {
            get { return productname; }
            set
            {
                if((String.IsNullOrEmpty(value)))
                {
                    throw new Exception("Please Enter Correct value");
                }
                else
                {
                    productname = value;
                }
            }
        }
        private int unitprice;
        public int Price
        {
            get { return unitprice; }
            set
            {
                if(unitprice==null)
                {
                    throw new Exception("Please Enter Correct value");
                }
                else
                {
                    unitprice = value;
                }
            }
        }
    }
}
