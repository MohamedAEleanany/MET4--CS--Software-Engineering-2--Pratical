using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Test___Calculator_Example;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddtion()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            var expectResult = 4;
           var actualResult = calc.add(2, 2);

            //Assert
            Assert.AreEqual(expectResult,actualResult);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            var expectResult = 0;
            var actualResult = calc.subtract(2, 2);

            //Assert
            Assert.AreEqual(expectResult, actualResult);
        }

        [TestMethod]
        public void TestMultiply()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            var expectResult = 4;
            var actualResult = calc.multiply(2, 2);

            //Assert
            Assert.AreEqual(expectResult, actualResult);
        }

        [TestMethod]
        public void TestDivide()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            var expectResult = 1;
            var actualResult = calc.divide(2, 2);

            //Assert
            Assert.AreEqual(expectResult, actualResult);
        }
    }
}
