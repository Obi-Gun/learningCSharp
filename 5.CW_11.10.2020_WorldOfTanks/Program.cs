using _5.CW_11._10._2020_TanksLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CW_11._10._2020_WorldOfTanks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            var soviets = new string[5] { "T34_1", "T34_2", "T34_3", "T34_4", "T34_5" };
            var sovArr = new Tank[5];
            var germans = new string[5] { "Panther_1", "Panther_2", "Panther_3", "Panther_4", "Panther_5"};
            var germArr = new Tank[5];
            for (var i = 0; i < 5; ++i)
            {
                sovArr[i] = new Tank(soviets[i], random);
                germArr[i] = new Tank(germans[i], random);
                Console.WriteLine($"{sovArr[i]} \tand {germArr[i]} \nwon {sovArr[i] * germArr[i]}");
            }
        }
    }
}
