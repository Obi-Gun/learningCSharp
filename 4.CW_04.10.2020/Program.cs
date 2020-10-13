using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _4.CW_04._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var devices = new List<Storage>
            {
                new FlashMemory(4 * 1024, USBTypeSpeed.USB2_0),
                new ExternalHDD(500 * 1024, USBTypeSpeed.USB2_0),
                new DVDdisk(50, 100, DiskType.OneSideDisk),
                new FlashMemory(8 * 1024, USBTypeSpeed.USB3_0, "samsung v2020"),
                new ExternalHDD(1000 * 1024, USBTypeSpeed.USB3_0, "WD red"),
                new DVDdisk(60, 100, DiskType.TwoSideDisk, "Sony CD Pro")
            };

            var program = new Program();
            program.Calc(devices, 565 * 1024, 780);
        }

        public void Calc(List<Storage> storages, int fullSizeMB, int sizeMB)
        {
            foreach (var storage in storages) 
            {
                var count = (int)Math.Round((double)fullSizeMB / (storage.CalcHowManyTimesFileCanBeCopied(sizeMB) * sizeMB), MidpointRounding.ToPositiveInfinity);
                var time = CalcTimeToCopy(storage, fullSizeMB);
                Console.WriteLine($"You should have {count} devices {storage}\n\tfor place {fullSizeMB}\n\tit will be copied {time}\n\n");
            }
        }

        public int CalcFullSpace(List<Storage> storages)
        {
            int res = 0;
            foreach (var storage in storages)
            {
                res += storage.FullSpaceMB;
            }
            return res;
        }

        public string CalcTimeToCopy(Storage storage, int sizeMB)
        {
/*            if (storage.IsEnoughSpace(sizeMB))
                return "Device do not have enough space to copy " + storage.ToString();*/

            var rawSec = storage.CalcTime(sizeMB);
            var hours = rawSec / 3600;
            var minutes = (rawSec - hours * 3600) / 60;
            var seconds = rawSec % 60;
            return $"{hours} hours : {minutes} minutes : {seconds} seconds";
        }

        public bool TryCopy(Storage storage, int sizeMB)
        {
            if (storage.Copy(sizeMB))
                return true;

            return false;
        }

        public void CopyToAll(List<Storage> storages, int sizeMB)
        {
            for (var i = 0; i < storages.Count; ++i)
            {
                TryCopy(storages[i], sizeMB);
            }
        }

        public int CalcCountOfDevicesToCopy(Storage storage, int sizeMB)
        {
            return (int) Math.Round((double)sizeMB / storage.FullSpaceMB, MidpointRounding.ToPositiveInfinity);
        }
    }
}
