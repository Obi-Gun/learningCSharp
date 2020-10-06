using System;
using System.Collections.Generic;
using System.Text;

namespace _4.CW_04._10._2020
{
    internal class FlashMemory : Storage
    {
        private int _speed { get; set; }

        internal FlashMemory(double size, USBType uSBType) : base("USB-flash", "34rrr34")
        {
            _speed = uSBType == USBType.USB2_0 ? USB._USB2_0Speed : USB._USB3_0Speed;
            FullSpace = size;
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
