using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11.CW_22._11._2020_ClassLib
{
    [Serializable]
    [ProtoContract]
    public class PC
    {
        public int SerialNumber { get; set; }

        public string Model { get; set; }

        public DateTime PurshaseDate { get; set; }

        public PC()
        {

        }

        public PC(int serialNumber, string model, DateTime purshaseDate)
        {
            SerialNumber = serialNumber;
            Model = model ?? throw new ArgumentNullException(nameof(model));
            PurshaseDate = purshaseDate;
        }

        public void ConnectToWifi()
        {

        }

        public void TurnOn()
        {

        }

        public void TurnOf()
        {

        }

        public override string ToString()
        {
            return $"S\\n {SerialNumber} model: {Model} purshase date {PurshaseDate}";
        }
    }
}
