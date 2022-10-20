using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public class Enrollment
    {
		private int _enrollno;

		public int Enrollmentnum
		{
			get { return _enrollno; }
			set { _enrollno = value; }
		}

		private int _fees;
		public int Fees
		{
			get { return _fees; }
			set { _fees = value; }
		}
        public bool IsFees()
        {
            return Fees >= 0;
        }

    }
}
