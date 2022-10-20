using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public class CustomerOrder
    {
        public void Discount(Customer cust , Order o)
        {
            if (cust.customerType==CustomerType.Premium)
            {
                o.Amount = o.Amount-((o.Amount * 10) / 100);
            }
            else if(cust.customerType == CustomerType.Gold) 
            { o.Amount = o.Amount - ((o.Amount * 20) / 100); }
        }
        public void GetCustomersList(Customer c1)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-H55UBBSP\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Scurity=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Customers",cn);
            SqlDataReader dr=cmd.ExecuteReader();
            List<Customer> custList = new List<Customer>();
            // Customer c = new Customer();
            while (dr.Read())
            {
                Customer cust = new Customer();
                cust.CustomerName = dr["ContactName"].ToString();
                cust.CustomerId = dr[0].ToString();

                // cust.CustID = dr[0].ToString();
                custList.Add(cust);

            }
            cn.Close(); 
            c1.Customers = custList;


        }
    }
}
