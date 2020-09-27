using System;
using System.Text;

namespace learningCSharp
{
    /// <summary>
    /// Lesson 3.
    /// </summary>
    class Program
    {
        struct Dimensions
        {
            public double Length;
            public double Width;

            public Dimensions(double len, double width)
            {
                Length = len;
                Width = width;
            }

            public void Print()
            {
                Console.WriteLine($"{Length} {Width}");
            }
        }

        static void Main(string[] args)
        {
            /*            Dimensions dimensions = new Dimensions(12, 10);
                        dimensions.Print();*/
            /*            Student student = new Student();
                        student.Print();*/
            Console.OutputEncoding = Encoding.UTF8;
            Bank bank = new Bank(1000000);
            Console.WriteLine("Текущий бонусный процент: " + Bank.GetBonus());
            Console.WriteLine("Ваш депозит на {0:C}, в кассе забрать:", 10000, bank.GetPercents(10000));
        }
    }
}

