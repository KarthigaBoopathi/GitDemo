using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CustomerOrderService;

namespace CustomerOrderService.Tests
{
    [TestFixture(CustomerType.Basic)]
    [TestFixture(CustomerType.Premium, 100)]
    public class CustomerOrdersTests
    {
        CustomerType ctype;
        CustomerType ctype1;
        Order order = new Order();
       public CustomerOrdersTests(CustomerType ctype)
        {
            this.ctype = ctype;
        }
        public CustomerOrdersTests(CustomerType ctype1, int amount)
        {
            this.ctype1 = ctype1;
            order.Amount = amount;
        }

        [TestCase]
        public void TestMethod()
        {

            Assert.IsTrue((ctype == CustomerType.Premium && order.Amount > 0));
            //  Assert.IsTrue(ctype == CustomerType.Basic);
        }

        [TestCase]
        public void TestMethod1()
        {

            Assert.IsTrue(ctype == CustomerType.Basic);

        }

        [TestCase]
        public void When_Premium_10percent()
        {
            Customer cust = new Customer();
            cust.CustomerId = "Boopathi";
            cust.CustomerName = "Karthiga";
            cust.customerType = CustomerType.Premium;
            Order o = new Order();
            o.OrderId = 11;
            o.ProductId = 35;
            o.Qty = 2;
            o.Amount = 100;
            CustomerOrder co = new CustomerOrder();
            co.Discount(cust, o);
            Assert.AreEqual(o.Amount, 90);
        }

        [TestCase]
        public void When_Gold_20percent()
        {
            Customer cust = new Customer();
            cust.CustomerId = "B";
            cust.CustomerName = "Sowmiya";
            cust.customerType = CustomerType.Gold;
            Order o = new Order();
            o.OrderId = 12;
            o.ProductId = 35;
            o.Qty = 2;
            o.Amount = 100;
            CustomerOrder co = new CustomerOrder();
            co.Discount(cust, o);
            Assert.AreEqual(o.Amount, 80);


        }

        [TestCase]
        public void FetchList()
        {
            CustomerOrder customerOrder = new CustomerOrder();
            Customer c1 = new Customer();

            customerOrder.GetCustomersList(c1);
            List<Customer> custList1 = new List<Customer>();
            custList1.Add(new Customer() { CustomerId = "sk", CustomerName = "sk" });
            custList1.Add(new Customer() { CustomerId = "ab", CustomerName = "ab" });
            Assert.AreEqual(custList1, c1.Customers);
        }
    }
}
