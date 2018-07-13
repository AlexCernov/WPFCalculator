using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFCalculator.Model;

namespace WPFCalculatorTests
{
    /// <summary>
    /// Summary description for ComplexTexts
    /// </summary>
    [TestClass]
    public class ComplexTexts
    {
        [TestMethod]
        public void TestConstructor()
        {
            Complex c = new Complex(2,3);
            Assert.AreEqual(2, c.Real);
            Assert.AreEqual(3, c.Img);
        }

        [TestMethod]
        public void TestAdd()
        {
            Complex a = new Complex(2, 3);
            Complex b = new Complex(2, 2);
            Complex c = new Complex(0, 0);
            c = a + b;
            Assert.AreEqual(c.Real, 4);
            Assert.AreEqual(c.Img, 5);
        }

        [TestMethod]
        public void TestSub()
        {
            Complex a = new Complex(4, 3);
            Complex b = new Complex(2, 2);
            Complex c = new Complex(0, 0);
            c = a - b;
            Assert.AreEqual(c.Real, 2);
            Assert.AreEqual(c.Img, 1);
        }

        [TestMethod]
        public void TestMul()
        {
            Complex a = new Complex(2, 1);
            Complex b = new Complex(1, 1);
            Complex c = new Complex(0, 0);
            c = a * b;
            Assert.AreEqual(c.Real, 1);
            Assert.AreEqual(c.Img, 3);
        }

        [TestMethod]
        public void TestDiv()
        {
            Complex a = new Complex(2, 2);
            Complex b = new Complex(1, 0);
            Complex c = new Complex(0, 0);
            c = a / b;
            Assert.AreEqual(c.Real, 2);
            Assert.AreEqual(c.Img, 2);
        }
    }
}
