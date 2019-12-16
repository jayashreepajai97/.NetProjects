using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {

        [TestMethod]

        public void TestMethod1()
        {
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            var calculator = new Calculator();

            int result = calculator.Add(4, 3);

            Assert.AreEqual(7, result);
        }
    }
  }


