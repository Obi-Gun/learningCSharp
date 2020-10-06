using System;
using System.Collections.Generic;
using System.Text;

namespace _4.CW_04._10._2020
{
    internal abstract class Storage
    {
        protected string _name;
        protected string _model;

        public int FullSpace { get; protected set; }
        public int _usedSpace { get; protected set; }
        public int FreeSpace { get; protected set; }

        internal Storage(string name, string model)
        {
            _name = name;
            _model = model;
        }

        public override string ToString()
        {
            return $"Name: {_name}\nModel: {_model}\nFullSpace: {FullSpace}\nFreeSpace: {FreeSpace}";
        }

        public abstract bool Copy(int size);

        public abstract int CalcCopyTimeSec(int sizeMB);

        protected abstract bool IsHasEnoughSpace(int sizeMB);
    }
}
