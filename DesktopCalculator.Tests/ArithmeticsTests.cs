using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;

namespace DesktopCalculator.Tests
{
    [TestClass]
    public class ArithmeticsTests
    {
        [TestMethod]
        public void TwoPlusTwoIsFour()
        {
            //Arrange
            int num1 = 2;
            int num2 = 2;
            string action = "+";
            int expectedResults = 4;
            Arithmetics arithmetics = new Arithmetics();
            //Act
            int actualResults = arithmetics.Calculate(num1, num2, action);
            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }
        [TestMethod]
        public void FiveDividedByZeroThrowsException()
        {
            //Arrange
            int num1 = 5;
            int num2 = 0;
            string action = "/";
           // int expectedResults = 4;
            Arithmetics arithmetics = new Arithmetics();
            bool exceptionThown = false;
            //Act
            try
            {
                int actualResults = arithmetics.Calculate(num1, num2, action);
            }
            catch (DivideByZeroException ex)
            {
                exceptionThown = true;
            }
            // Assert
            Assert.IsTrue(exceptionThown);
        }
        [TestMethod]
        public void NonExistingActionThrowsException()
        {
            //Arrange
            int num1 = 5;
            int num2 = 0;
            string action = "not found";
            // int expectedResults = 4;
            Arithmetics arithmetics = new Arithmetics();
            bool isExceptionthrown = false;
            //Act
            try
            {
                int actualResults = arithmetics.Calculate(num1, num2, action);
            }
            catch (Exception ex)
            {
                isExceptionthrown = true;
            }
            // Assert
            Assert.IsTrue(isExceptionthrown);
        }
    }
}
