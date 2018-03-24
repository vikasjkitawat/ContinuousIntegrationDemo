using System;
using ContinuousIntegrationDemo.Commons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContinuousIntegrationDemo.Tests.CommonsTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTest()
        {
            var addCalculator = new Calculator();
            var res = addCalculator.Add(20, 10);
            Assert.AreEqual(res, 30);
        }

        [TestMethod]
        public void SubTest()
        {
            var subCalculator = new Calculator();
            var res = subCalculator.Sub(20, 10);
            Assert.AreEqual(res, 10);
        }

        [TestMethod]
        public void MulTest()
        {
            var mulCalculator = new Calculator();
            var res = mulCalculator.Mul(20, 10);
            Assert.AreEqual(res, 200);
        }

        [TestMethod]
        public void DivTest()
        {
            var divCalculator = new Calculator();
            var res = divCalculator.Div(20, 10);
            Assert.AreEqual(res, 2);
        }

        //TODO
        [TestMethod]
        public void DivTest_DivideByZeroError()
        {
            var divCalculator = new Calculator();
            var res = divCalculator.Div(20, 10);
            Assert.AreEqual(res, 2);
        }
    }
}
