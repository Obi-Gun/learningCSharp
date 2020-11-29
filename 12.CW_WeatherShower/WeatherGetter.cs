using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace _12.CW_WeatherShower
{
    public class WeatherGetter
    {
        private List<WeatherReport> _reports = new List<WeatherReport>();
        private Regex _regex = new Regex(@"(\d{1,3})|(\s\d{1,2}\s)");

        public List<WeatherReport> GetWeather(int id)
        {
            
            string m_strFilePath = $"http://informer.gismeteo.by/rss/{id}.xml";
            XmlDocument myXmlDocument = new XmlDocument();
            myXmlDocument.Load(m_strFilePath);
            OutputNode(myXmlDocument, _reports, id);
            return _reports;
        }

        public Dictionary<string, int> GetIdList()
        {
            return new Dictionary<string, int>
            {
                { "Москва", 27612 },
                { "Rostov-on-Don", 34731 }
            };
        }

        private void OutputNode(XmlNode node, List<WeatherReport> reports, int id)
        {
            if (node.HasChildNodes)
            {
                if (node.Name == "item" && node.FirstChild.Name == "title")
                {
                    string city = "";
                    var tempMin = 0.0;
                    var tempMax = 0.0;
                    var pressureMin = 0.0;
                    var pressureMax = 0.0;
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        if (child.Name == "title")
                        {
                            city = child.FirstChild.Value;
                        }
                        if (child.Name == "description")
                        {
                            var res = _regex.Matches(child.FirstChild.Value);
                            double.TryParse(res[0].Value, out tempMin);
                            double.TryParse(res[1].Value, out tempMax);
                            double.TryParse(res[2].Value, out pressureMin);
                            double.TryParse(res[3].Value, out pressureMax);
                        }
                    }
                    reports.Add(new WeatherReport()
                    {
                        City = city,
                        Id = id,
                        TemperatureMin = tempMin,
                        TemperatureMax = tempMax,
                        PressureMin = pressureMin,
                        PressureMax = pressureMax
                    });
                    return;
                }
                foreach (XmlNode child in node.ChildNodes)
                {
                    OutputNode(child, reports, id);
                }
            }
        }
    }
}
