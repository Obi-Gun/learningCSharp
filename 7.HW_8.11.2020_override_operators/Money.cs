using System;
using System.Collections.Generic;
using System.Text;

namespace _7.HW_8._11._2020_override_operators
{
    public class Money
    {
        private int _cents = 0;

        public int Cents {
            get { return _cents; }
            private set 
            {
                if (value < 0)
                    throw new Exception("Cents count can't be less then zero");
                _cents = value;
            } 
        }

        public Money(int dollars, int cents)
        {
            if (cents < 0)
                throw new ArgumentNullException("cents count can't be less than 0");
            if (dollars < 0)
                throw new ArgumentNullException("dollars count can't be less than 0");
            Cents = cents + dollars * 100;
        }

        public Money(int cents) : this(0, cents) 
        { }

        private void CheckIsBankrupt()
        {
            if (Cents < 0)
                throw new Exception("client is bankrupt");
        }

        public static Money operator +(Money money1, Money money2)
        {
            return new Money(money1.Cents + money2.Cents);
        }

        public static Money operator -(Money money1, Money money2)
        {
            return new Money(money1.Cents - money2.Cents);
        }

        public static Money operator /(Money money1, int times)
        {
            if (times == 0)
                throw new DivideByZeroException();
            return new Money(money1.Cents / times);
        }

        public static Money operator *(Money money1, int times)
        {
            return new Money(money1.Cents * times);
        }

        public static Money operator ++(Money money)
        {
            ++money.Cents;
            return money;
        }

        public static Money operator --(Money money)
        {
            --money.Cents;
            return money;
        }

        public static bool operator <(Money money1, Money money2)
        {
            return money1.Cents < money2.Cents;
        }

        public static bool operator >(Money money1, Money money2)
        {
            return money1.Cents > money2.Cents;
        }

        public static bool operator ==(Money money1, Money money2)
        {
            return money1.Cents == money2.Cents;
        }

        public static bool operator !=(Money money1, Money money2)
        {
            return money1.Cents != money2.Cents;
        }

        public override string ToString()
        {
            return $"{Cents / 100} dollars {Cents % 100} cents";
        }
    }
}
