using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService.Tests
{
    [TestFixture]
    public class EmployeeServiceTest
    {
        [TestCase(16, ExpectedResult = false)]
        [TestCase(60, ExpectedResult = true)]
        [TestCase(36, ExpectedResult = false)]
        [TestCase(76, ExpectedResult = true)]
        public void GetAge()
        {
            Employee employee = new Employee();
            employee.EmployeeID = 1;
            employee.EmployeeName = "hari";
            employee.Age = 60;
            bool ans = employee.IsSenior();
            Assert.IsTrue(ans==true);
        }

    }
}
