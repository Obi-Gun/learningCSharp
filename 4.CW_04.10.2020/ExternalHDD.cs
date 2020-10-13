using System;
using System.Collections.Generic;
using System.Text;

namespace _4.CW_04._10._2020
{
    internal class ExternalHDD : Storage
    {
        /// <summary>
        /// MB per second.
        /// </summary>
        private int _speed { get; set; }

        internal ExternalHDD(int sizeMB, USBTypeSpeed uSBType, string model = "WD Green") : base("ExternalHDD", model, sizeMB)
        {
            _speed = (int)uSBType;
        }

        public override bool Copy(int sizeMB)
        {
            if (!IsEnoughSpace(sizeMB))
                return false;
            FreeSpaceMB -= sizeMB;
            UsedSpaceMB += sizeMB;
            return true;
        }

        public override string ToString()
        {
            return $"Name: {_name}\nModel: {_model}\nFullSpace: {FullSpaceMB}\nFreeSpace: {FreeSpaceMB}\nSpeed: {_speed}";
        }

        public override int CalcTime(int sizeMB)
        {
            return (int)Math.Round((double)sizeMB / _speed, MidpointRounding.ToPositiveInfinity);
        }

        internal override bool IsEnoughSpace(int sizeMB)
        {
            if (sizeMB <= FreeSpaceMB)
                return true;
            return false;
        }
    }
}
