using System;

namespace _7.HW_8._11._2020_override_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dollars = 13;
                var cents = 43;
                var money = new Money(dollars, cents);
                var money2 = new Money(567, 12);

                Console.WriteLine($"{money2} + {money} = {money2 + money}");
                Console.WriteLine($"{money2} - {money} = {money2 - money}");
                Console.WriteLine($"{money2} / {2} = {money2 / 2}");
                Console.WriteLine($"{money2} * {3} = {money2 * 3}");
                var money2copy = new Money(money2.Cents);
                Console.WriteLine($"{money2copy} ++ = {money2++}");
                var money3copy = new Money(money2.Cents);
                Console.WriteLine($"{money3copy} -- = {--money2}");
                Console.WriteLine($"{money2} > {money} = {money2 > money}");
                Console.WriteLine($"{money2} < {money} = {money2 < money}");
                Console.WriteLine($"{money2} == {money} = {money2 == money}");
                Console.WriteLine($"{money2} != {money} = {money2 != money}");
                var exeptionMoney = new Money(-3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
