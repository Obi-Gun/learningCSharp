using System;
using System.Collections.Generic;
using System.Text;


namespace _11.CW_22._11._2020_Serialization
{
    [Coder("Bob", "2020, 11, 22")][Serializable]
    public class Apple
    {
        [Coder("Tommy", "2020, 7, 22")]
        public string Color;

        [Coder("Rex", "1999, 7, 22")]
        public int Radius;

        [Coder("PPSH", "2020, 1, 22")]
        public void Grow()
        {

        }

        [Coder("PPS", "2020, 1, 4")]
        public void GetSunshine()
        {

        }

        public override string ToString()
        {
            return $"{Color} {Radius}";
        }
    }
}