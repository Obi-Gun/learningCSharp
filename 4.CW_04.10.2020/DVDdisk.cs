using System;
using System.Collections.Generic;
using System.Text;

namespace _4.CW_04._10._2020
{
    internal class DVDdisk : Storage
    {
        private int _writeSpeed { get; set; }
        private int _readSpeed { get; set; }

        internal DVDdisk(int writeSpeed, int readSpeed, DiskType diskType) : base("DVDdisk", "34rrr34")
        {
            _writeSpeed = writeSpeed;
            _readSpeed = readSpeed;
            FullSpace = diskType == DiskType.OneSideDisk ? 4.7 : 9.0;
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
            return $"Name: {_name}\nModel: {_model}\nFullSpace: {FullSpace}\nFreeSpace: {FreeSpace}\nWriteSpeed: {_writeSpeed}\nReadSpeed: {_readSpeed}";
        }

        public override int CalcCopyTimeSec(int sizeMB)
        {
            return sizeMB / _writeSpeed;
        }
    }
}
