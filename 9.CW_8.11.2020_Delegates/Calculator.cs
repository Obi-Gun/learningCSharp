using System;
using System.Collections.Generic;
using System.Text;

namespace _9.CW_8._11._2020_Delegates
{
    public class Calculator
    {
        public double Add (double x, double y)
        {
            return x + y;
        }

        public static double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mult(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();

            return x / y;
        }
    }
}
