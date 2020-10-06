using System;
using System.Collections.Generic;
using System.Text;

namespace _4.CW_04._10._2020
{
    internal class ExternalHDD : Storage
    {
        private int _speed { get; set; }

        internal ExternalHDD(double size, USBType uSBType) : base("ExternalHDD", "gggggExternalHDD")
        {
            FullSpace = size;
            _speed = uSBType == USBType.USB2_0 ? USB._USB2_0Speed : USB._USB3_0Speed;
        }

        public override bool Copy(int size)
        {
            if (size > FreeSpace)
                return false;
            FreeSpace -= size;
            _usedSpace += size;
            return true;
        }

        public override string ToString()
        {
            return $"Name: {_name}\nModel: {_model}\nFullSpace: {FullSpace}\nFreeSpace: {FreeSpace}\nSpeed: {_speed}";
        }
    }
}
