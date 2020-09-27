using System;
using System.Collections.Generic;
using System.Text;

namespace learningCSharp
{
    class Bank
    {
        private double _currBalance;

        public Bank(double balance)
        {
            _currBalance = balance;
        }

        static Bank()
        {
            _bonus = 1.04;
        }

        private static double _bonus;
        public static void SetBonus(double newRate)
        {
            _bonus = newRate;
        }

        public static double GetBonus()
        {
            return _bonus;
        }

        public double GetPercents(double summa)
        {
            if ((_currBalance - summa) > 0)
            {
                double percent = summa * _bonus;
                _currBalance -= percent;
                return percent;
            }
            return -1;
        }
    }
}
