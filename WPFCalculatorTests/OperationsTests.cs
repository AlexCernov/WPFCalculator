using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCalculator.Model;

namespace WPFCalculator.Tests
{
    [TestClass()]
    public class OperationsTests
    {
        [TestMethod()]
        public void TestAdd()
        {
            Complex a = new Complex(2, 3);
            Complex b = new Complex(2, 3);
            Assert.AreEqual(4,(a+b).Real);
            Assert.AreEqual(6, (a + b).Img);
            //Assert.Fail();
        }

        [TestMethod()]
        public void TestSub()
        {
            Complex a = new Complex(3, 3);
            Complex b = new Complex(2, 3);
            Assert.AreEqual(1, (a - b).Real);
            Assert.AreEqual(0, (a - b).Img);
            //Assert.Fail();
        }

        [TestMethod()]
        public void TestMul()
        {
            Complex a = new Complex(3, 3);
            Complex b = new Complex(2, 3);
            Assert.AreEqual(-3, (a * b).Real);
            Assert.AreEqual(15, (a * b).Img);
            //Assert.Fail();
        }

        [TestMethod()]
        public void TestDiv()
        {
            Complex a = new Complex(3, 3);
            Complex b = new Complex(1, 0);
            Assert.AreEqual(3, (a / b).Real);
            Assert.AreEqual(3, (a / b).Img);
            //Assert.Fail();
        }


    }
}