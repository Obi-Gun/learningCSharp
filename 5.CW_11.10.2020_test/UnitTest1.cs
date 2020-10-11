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
            var ex = Assert.Catch<Exception>(() => arr[16] = 100);
        }

        [Test]
        public void SetArrValue_ArgumentIsMinIndex_NoException()
        {
            var arr = new RangeOfArray(-9, 15);
            Assert.DoesNotThrow(() => arr[-9] = 100);
        }

        [Test]
        public void SetArrValue_ArgumentIsMaxIndex_NoException()
        {
            var arr = new RangeOfArray(-9, 15);
            Assert.DoesNotThrow(() => arr[15] = 100);
        }

        [Test]
        public void SetArrValue_SetValue_GetTheSameValue()
        {
            var arr = new RangeOfArray(-9, 15);
            arr[15] = 100;
            if (arr[15] == 100)
            {
                Assert.Pass();
                return;
            }
            Assert.Fail();
        }

        [Test]
        public void SetArrValue_SetValue_GetTheSameValue2()
        {
            var arr = new RangeOfArray(-9, 15);
            arr[-9] = 100;
            if (arr[-9] == 100)
            {
                Assert.Pass();
                return;
            }
            Assert.Fail();
        }
    }
}