using System;
using System.Collections.Generic;
using System.Text;

namespace _4.CW_04._10._2020
{
    internal abstract class Storage
    {
        protected string _name;
        protected string _model;

        public int FullSpaceMB { get; protected set; }
        public int UsedSpaceMB { get; protected set; }
        public int FreeSpaceMB { get; protected set; }

        internal Storage(string name, string model, int sizeMB)
        {
            _name = name ?? throw new NullReferenceException();
            _model = model ?? throw new NullReferenceException();
            UsedSpaceMB = 0;
            FullSpaceMB = sizeMB;
            FreeSpaceMB = FullSpaceMB;
        }

        public override string ToString()
        {
            return $"Name: {_name}\nModel: {_model}\nFullSpace: {FullSpaceMB}\nFreeSpace: {FreeSpaceMB}";
        }

        /// <summary>
        /// Copy a data to device.
        /// </summary>
        /// <param name="sizeMB">how many megabytes should be copied.</param>
        /// <returns>True if successful, false if unsuccessful.</returns>
        public abstract bool Copy(int sizeMB);

        /// <summary>
        /// Calculate Time To Copy In Seconds.
        /// </summary>
        /// <param name="sizeMB">how many megabytes should be copied.</param>
        /// <returns>Number of bytes.</returns>
        public abstract int CalcTime(int sizeMB);

        /// <summary>
        /// Calc if enough space on device.
        /// </summary>
        /// <param name="sizeMB"></param>
        /// <returns>True if enough space, otherwise false.</returns>
        internal abstract bool IsEnoughSpace(int sizeMB);

        public int CalcHowManyTimesFileCanBeCopied(int sizeMB)
        {
            return FullSpaceMB / sizeMB;
        }
    }
}
