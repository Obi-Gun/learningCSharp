using System;
using System.Collections.Generic;
using System.Text;

namespace _11.CW_22._11._2020_Serialization
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Field)]
    public class CoderAttribute : Attribute
    {
        private string _name;
        private DateTime _dateTime;

        public CoderAttribute(string name, string dateTime)
        {
            try
            {
                _name = name ?? throw new ArgumentNullException(nameof(name));
                if (dateTime == null)
                    throw new ArgumentNullException(nameof(dateTime));
                _dateTime = Convert.ToDateTime(dateTime);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override string ToString()
        {
            return $"coder: {_name} date: {_dateTime}"; 
        }
    }
}
