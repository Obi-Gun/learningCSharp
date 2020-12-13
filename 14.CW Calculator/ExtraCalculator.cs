using System;
using System.Collections.Generic;
using System.Text;

namespace _14.CW_Calculator
{
    public class ExtraCalculator
    {
        private ICalculator _calculator;

        public ExtraCalculator(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public double DoSmth()
        {
            throw new NotImplementedException();
        }

        public double PowSqureSum(double a, double b)
        {
            if (_calculator.Type == CalculatorType.Decimal)
                return _calculator.PowSqureSum(a, b);
            if (_calculator.Type == CalculatorType.Oct)
                throw new NotImplementedException("fff");
            if (_calculator.Type == CalculatorType.Hex)
                throw new NotImplementedException("fff");
            if (_calculator.Type == CalculatorType.None)
                throw new NotImplementedException("fff");
            else
                throw new Exception("gfgg");
        }
    }
}
