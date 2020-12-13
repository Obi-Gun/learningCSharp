using _14.CW_Calculator;
using NSubstitute;
using NUnit.Framework;
using System;

namespace _14.CW_13._12._2020_UnitTests
{
    [TestFixture, Author("Sahatir")]
    public class ExtraCalculatorTest
    {
        private ICalculator _calculatorMock;
        private ExtraCalculator _extraCalculator;

        [SetUp]
        public void Init()
        {
            _calculatorMock = Substitute.For<ICalculator>();
            _extraCalculator = new ExtraCalculator(_calculatorMock);
        }

        [TestCase(4, 3, CalculatorType.Decimal, 49)]
        public void PowSqureSum_GiveCorrectValues_ReturnsCorrectResult(int a, int b, CalculatorType calculatorType, int expectedRes)
        {
            // Arrange
            _calculatorMock.PowSqureSum(a, b).Returns(Math.Pow(a + b, 2));
            _calculatorMock.Type.Returns(CalculatorType.Decimal); //_calculatorMock.Type = calculatorType;

            // Act
            var res = _extraCalculator.PowSqureSum(a, b);

            // Assert
            Assert.AreEqual(expectedRes, res, 0);
        }

        [TestCase(4, 3, CalculatorType.Hex, 49)]
        [TestCase(4, 3, CalculatorType.None, 49)]
        [TestCase(4, 3, CalculatorType.Oct, 49)]
        [TestCase(4, 3, CalculatorType.Binary, 49)]
        public void PowSqureSum_GiveNotImplementedParams_ThrowsNIEx(int a, int b, CalculatorType calculatorType, int expectedRes)
        {
            // Arrange
            _calculatorMock.PowSqureSum(a, b).Returns(Math.Pow(a + b, 2));
            _calculatorMock.Type = calculatorType;

            // Act and Assert
            Assert.Throws<NotImplementedException>(() => _extraCalculator.PowSqureSum(a, b));
        }
    }
}
