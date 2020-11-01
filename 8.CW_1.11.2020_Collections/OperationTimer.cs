using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace _8.CW_1._11._2020_Collections
{
    public class OperationTimer : IDisposable
    {
        private long _startTime;
        private string _text;
        private int _collectionCount;

        public OperationTimer(string text)
        {
            PrepareForOperation();
            _text = text;
            _collectionCount = GC.CollectionCount(0);
            _startTime = Stopwatch.GetTimestamp();
        }

        public void Dispose()
        {
            Console.WriteLine($"{ _text}\t{(Stopwatch.GetTimestamp() - _startTime) / (double)Stopwatch.Frequency:0.00} " +
                $"секунды(сборок мусора { GC.CollectionCount(0) - _collectionCount})");
        }

        private static void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
