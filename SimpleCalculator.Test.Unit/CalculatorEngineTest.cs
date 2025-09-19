using CalculationsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine engine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {

            int number1 = 1;
            int number2 = 2;
            int expected = 3;
            double? result = engine.Calculate("add", number1, number2);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {

            int number1 = 1;
            int number2 = 2;
            int expected = 3;
            double? result = engine.Calculate("+", number1, number2);
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 5;
            int number2 = 3;
            int expected = 2;
            double? result = engine.Calculate("subtract", number1, number2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 5;
            int number2 = 3;
            int expected = 2;
            double? result = engine.Calculate("-", number1, number2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 4;
            int number2 = 3;
            int expected = 12;
            double? result = engine.Calculate("multiplied by", number1, number2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 4;
            int number2 = 3;
            int expected = 12;
            double? result = engine.Calculate("*", number1, number2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 10;
            int number2 = 2;
            int expected = 5;
            double? result = engine.Calculate("divided by", number1, number2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 10;
            int number2 = 2;
            int expected = 5;
            double? result = engine.Calculate("/", number1, number2);
            Assert.AreEqual(expected, result);
        }
    }
}
