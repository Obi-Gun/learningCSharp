using System;
using System.Runtime.CompilerServices;

namespace _4.CW_04._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Storage[]
            {
                new FlashMemory(4, USBType.USB2_0),
                new ExternalHDD(1000, USBType.USB2_0),
                new DVDdisk(50, 100, DiskType.OneSideDisk),
                new FlashMemory(4, USBType.USB3_0),
                new ExternalHDD(1000, USBType.USB3_0),
                new DVDdisk(50, 100, DiskType.TwoSideDisk)
            };


        }

        private int CalcCommonFullSpace(Storage[] storages)
        {
            int res = 0;
            foreach (var storage in storages)
            {
                res += storage.FullSpace;
            }
            return res;
        }

        private string CalcTimeToCopy(Storage storage, int size)
        {
            if (storage.FreeSpace > size)
                return new string($"{size / storage.sp}")
            return new string(storage.Copy(size))
        }
    }
}
