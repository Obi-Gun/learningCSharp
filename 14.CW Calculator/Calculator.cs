using System;

namespace _14.CW_Calculator
{
    public class Calculator
    {
        public double Divide(double first, double second)
        {
            if (second == 0)
                throw new DivideByZeroException(nameof(second));
            return first / second;
        }
    }
}
