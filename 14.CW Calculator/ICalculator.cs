using System;
using System.Collections.Generic;
using System.Text;

namespace _14.CW_Calculator
{
    public interface ICalculator
    {
        CalculatorType Type { get; set; }

        double PowSqureSum(double a, double b);

        double DoSmth();
    }
}
