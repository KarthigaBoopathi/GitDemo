using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService.Tests
{
    //stub
    [TestFixture]
    public class Class1Test
    {
            [TestCase]
            public void TestMethod1()
            {
                //Act  
                StubExtensionManager stub = new StubExtensionManager();
                FileChecker checker = new FileChecker(stub);

                //Action  
                bool IsTrueFile = checker.CheckFile("myFile.whatever");

                //Assert  
                Assert.AreEqual(true, IsTrueFile);
            }
     }

    //------------------------------------------------------------------

    [TestFixture]
    class Test1
    {
        int s;
        [SetUp] //----to execute a piece of code in each test case 
        [Test]
        public void Add() //----compulsory/first in the sequenece
        {
        int x = 10;
        int y = 20;
        s=x+y;
        Console.WriteLine(s);
}
    [Test]
    public void subtract()
    {
        int p = s - 10;
        Console.WriteLine(p);
        Assert.AreEqual(p, 20);
    }
    [Test]
    [TearDown] //----------------Last in the sequence of execution
    public void Multiply()
    {
        int x = 100;
        int y = 20;
        int result = x * y;
        Console.WriteLine(result);
        Assert.AreEqual(result, 30);
    }

}

    }

