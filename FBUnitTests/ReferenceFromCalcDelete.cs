using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTesting
{
    public class Calculator
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumTestMethod1()
        {
            // Arrange - Initializes object and sets thev alue of the data
            // that is passed to the method under test.
            int number1 = 2;
            int number2 = 2;
            int expected = 4;
            Calculator calc = new Calculator();

            // Act - Invoke our method under test with the parameters.
            int actual = calc.Sum(number1, number2);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplyTestMethod1()
        {
            // Arrange - Initializes object and sets thev alue of the data
            // that is passed to the method under test.
            int number1 = 3;
            int number2 = 2;
            int expected = 6;
            Calculator calc = new Calculator();

            // Act - Invoke our method under test with the parameters.
            int actual = calc.Multiply(number1, number2);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractTestMethod1()
        {
            // Arrange - Initializes object and sets thev alue of the data
            // that is passed to the method under test.
            int number1 = 10;
            int number2 = 5;
            int expected = 5;
            Calculator calc = new Calculator();

            // Act - Invoke our method under test with the parameters.
            int actual = calc.Subtract(number1, number2);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideTestMethod1()
        {
            // Arrange - Initializes object and sets thev alue of the data
            // that is passed to the method under test.
            int number1 = 3;
            int number2 = 3;
            int expected = 1;
            Calculator calc = new Calculator();

            // Act - Invoke our method under test with the parameters.
            int actual = calc.Divide(number1, number2);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideTestMethod2()
        {
            // Arrange - Initializes object and sets thev alue of the data
            // that is passed to the method under test.
            int number1 = 0;
            int number2 = 3;
            int expected = 0;
            Calculator calc = new Calculator();

            // Act - Invoke our method under test with the parameters.
            int actual = calc.Divide(number1, number2);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideTestMethod3()
        {
            // Arrange - Initializes object and sets thev alue of the data
            // that is passed to the method under test.
            int number1 = 3;
            int number2 = 0;
            int expected = 0;
            Calculator calc = new Calculator();

            // Act - Invoke our method under test with the parameters.
            int actual = calc.Divide(number1, number2);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(expected, actual);
        }
    }
}
