using _12.CW_WeatherShower;
using System;
using System.Text;
using System.Xml;

namespace _12.CW_29._11._2020_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var weatherGetter = new WeatherGetter();
            var list = weatherGetter.GetIdList();
            var rep = weatherGetter.GetWeather(list["Rostov-on-Don"]);
            foreach (var report in rep)
                Console.WriteLine(report.ToString());
        }


    }
}
