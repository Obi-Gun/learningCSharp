using System;
using System.Collections.Generic;
using System.Text;

namespace _9.CW_8._11._2020_Delegates
{
    public class Dispacher : IHuman
    {
        public event AnonimDelegateDouble eventDouble;
        public event AnonimDelegateInt eventVoid;

        public double OnEventDouble(double x, double y)
        {
            if (eventDouble != null)
            {
                return eventDouble(x, y);
            }
            throw new NullReferenceException();
        }

        public void OnEventVoid(int n = 0)
        {
            if (eventVoid != null)
            {
                eventVoid(n);
            }
        }
    }
}
