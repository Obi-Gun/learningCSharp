using System;
using System.Collections.Generic;
using System.Text;

namespace _4.CW_04._10._2020
{
    internal class USB
    {
        internal static int _USB2_0Speed = 1024 * 10;
        internal static int _USB3_0Speed = 1024 * 50;
    }

    internal enum USBType
    {
        USB2_0,
        USB3_0
    }
}
