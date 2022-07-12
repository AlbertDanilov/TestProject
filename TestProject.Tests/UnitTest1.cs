using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestProject.Helpers;

namespace TestProject.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculator_5_plus_7_result_12()
        {
            double n1 = 5D;
            double n2 = 7D;
            double expected = 12D;

            double result = Calculator.Plus(n1, n2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_10_to_2_result_5()
        {
            double n1 = 10D;
            double n2 = 2D;
            double expected = 5D;

            double result = Calculator.Divide(n1, n2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "Divide by zero detected!")]
        public void Divide_10_to_0_result_Exeption()
        {
            double n1 = 10D;
            double n2 = 0D;

            double result = Calculator.Divide(n1, n2);
        }

    }
}
