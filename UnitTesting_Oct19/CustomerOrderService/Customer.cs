using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public enum CustomerType
    {
        Basic,Premium,Gold
    }
    public class Customer
    {
		private string _custid;

		public string CustomerId
		{
			get { return _custid; }
			set { _custid = value; }
		}

        private string _custname;

        public string CustomerName
        {
            get { return _custname; }
            set { _custname= value; }
        }

        public CustomerType customerType { get; set; }
      public  List<Customer> Customers { get; set; }
    }
}
