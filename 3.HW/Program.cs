using System;

namespace _3.HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var models = new string[]{ "BMW", "Opel", "Audi", "Honda", "Toyota" };
            var arr = new Car[5];
            for (var i = 0; i < 5; ++i)
                arr[i] = new Car(models[i]);
        }
    }
}
