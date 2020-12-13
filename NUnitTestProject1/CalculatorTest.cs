using _14.CW_Calculator;
using NUnit.Framework;
using System;

namespace _14.CW_13._12._2020_UnitTests
{
    [TestFixture, Author("Sahatir")]
    public class CalculatorTest
    {
        private Calculator _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new Calculator();
        }

        [TestCase(3, 3, 1)]
        [TestCase(10, 3, 3.33)]
        [TestCase(10, 5, 2)]
        public void Divide_GiveTwoDelimeters_ReturnCorrectResult(double first, double delimeter, double expectedResult)
        {
            //Act
            var result = _calc.Divide(first, delimeter);

            //Assert
            Assert.AreEqual(expectedResult, result, 0.2);
        }

        [TestCase(3, 0)]
        [TestCase(10, 0)]
        [TestCase(-6, 0)]
        [TestCase(0, 0)]
        public void Divide_DivByZero_ThrowDivByZeroException(double first, double delimeter)
        {
            //Act and Assert
            Assert.Throws<DivideByZeroException>(() => _calc.Divide(first, delimeter));
        }
    }
}