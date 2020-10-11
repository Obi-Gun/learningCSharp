using _5.CW_11._10._2020;
using NUnit.Framework;
using System;

namespace _5.CW_11._10._2020_test
{
    public class Tests
    {
        [Test]
        public void SetArrValue_ArgumentLowerThenMinIndex_ThrowsArgumentOutOfRangeException()
        {
            var arr = new RangeOfArray(-9, 15);
            var ex = Assert.Catch<Exception>(() => arr[-10] = 100);
        }

        [Test]
        public void SetArrValue_ArgumentBiggerThenMaxIndex_ThrowsArgumentOutOfRangeException()
        {
            var arr = new RangeOfArray(-9, 15);
            var ex = Assert.Catch<Exception>(() => arr[-16] = 100);
        }
    }
}