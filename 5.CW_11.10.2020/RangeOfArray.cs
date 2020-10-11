using System;
using System.Collections.Generic;
using System.Text;

namespace _5.CW_11._10._2020
{
    public class RangeOfArray
    {
        private int[] _array;
        private int _leftBorder;
        private int _rightBorder;

        public int Length { get => _array.Length; }
        public int this[int index]
        {
            get 
            {
                if (index < _leftBorder || index > _rightBorder)
                    throw new ArgumentOutOfRangeException();
                return _array[index - _leftBorder]; 
            }
            set
            {
                if (index < _leftBorder || index > _rightBorder)
                    throw new ArgumentOutOfRangeException();
                _array[index - _leftBorder] = value;
            }
        }

        public RangeOfArray(int leftBorder, int rightBorder)
        {
            if (leftBorder > rightBorder)
            {
                var tmp = leftBorder;
                leftBorder = rightBorder;
                rightBorder = tmp;
            }
            _array = new int[rightBorder - leftBorder + 1];
            _leftBorder = leftBorder;
            _rightBorder = rightBorder;
        }


    }
}
