using System;
using System.Collections.Generic;
using System.Text;

namespace _4.CW_04._10._2020
{
    internal class DVDdisk : Storage
    {
        private int _writeSpeed { get; set; }
        private int _readSpeed { get; set; }

        internal DVDdisk(int writeMBperSec, int readMBperSec, DiskType diskType, string model = "Sony CD") : base("DVDdisk", model, (int)diskType)
        {
            _writeSpeed = writeMBperSec;
            _readSpeed = readMBperSec;
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
            return $"Name: {_name}\nModel: {_model}\nFullSpace: {FullSpaceMB}\nFreeSpace: {FreeSpaceMB}\nWriteSpeed: {_writeSpeed}\nReadSpeed: {_readSpeed}";
        }

        public override int CalcTime(int sizeMB)
        {
            return (int)Math.Round((double)sizeMB / _writeSpeed, MidpointRounding.ToPositiveInfinity);
        }

        internal override bool IsEnoughSpace(int sizeMB)
        {
            if (sizeMB <= FreeSpaceMB)
                return true;
            return false;
        }
    }
}
