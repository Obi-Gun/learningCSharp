using System;

namespace _12.CW_WeatherShower
{
    public class WeatherReport
    {
        public string City;
        public int Id;
        public double TemperatureMin;
        public double TemperatureMax;
        public double PressureMin;
        public double PressureMax;

        public override string ToString()
        {
            return $"в {City} id {Id} температура от {TemperatureMin} до {TemperatureMax} давление от {PressureMin} до {PressureMax}";
        }
    }
}
