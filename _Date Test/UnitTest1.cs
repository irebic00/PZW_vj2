using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PZW_Lab2;

namespace _Date_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSimpleConstructor()
        {
            var date = new _Date(1,1,2015);

            Assert.AreEqual(1, date.Month, "");
            Assert.AreEqual(1, date.Day, "");
            Assert.AreEqual(2015, date.Year , "");
        }

        [TestMethod]
        public void TestStandardLeapYear()
        {
            var date = new _Date(1, 1, 1988);

            Assert.AreEqual(true, date.isLeapYear(), "1988 should be a leap year");
        }

        [TestMethod]
        public void TestHundrentsLeapYear()
        {
            var date = new _Date(1, 1, 1900);

            Assert.AreEqual(false, date.isLeapYear(), "1900 should not be a leap year");
        }
    }
}
