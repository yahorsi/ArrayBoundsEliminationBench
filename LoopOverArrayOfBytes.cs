﻿using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Bdn1
{
    [DisassemblyDiagnoser]
    public class LoopOverArrayOfBytes
    {
        private byte[] _byteData;
        private List<byte> _byteDataList;

        [Params(50)]
        public int N { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            _byteData = new byte[N];

            for (int i = 0; i < _byteData.Length; ++i)
            {
                _byteData[i] = (byte)i;
            }

            _byteDataList = new List<byte>(_byteData.Length);
            _byteDataList.AddRange(_byteData);
        }

        [Benchmark(Baseline = true)]
        public int Foreach()
        {
            var data = _byteData;
            int sum = 0;

            foreach (var n in data)
            {
                sum += n;
            }

            return sum;
        }

        [Benchmark]
        public int ForSimple()
        {
            int sum = 0;

            for (int i = 0; i < _byteData.Length; ++i)
            {
                sum += _byteData[i];
            }

            return sum;
        }

        [Benchmark]
        public int ForLocalCached()
        {
            var data = _byteData;
            int sum = 0;

            for (int i = 0; i < data.Length; ++i)
            {
                sum += data[i];
            }

            return sum;
        }

        [Benchmark]
        public int ListForeachSimple()
        {
            int sum = 0;
            foreach (var n in _byteDataList)
            {
                sum += n;
            }

            return sum;
        }

        [Benchmark]
        public int ListForSimple()
        {
            int sum = 0;
            for (int i = 0; i < _byteDataList.Count; ++i)
            {
                sum += _byteDataList[i];
            }

            return sum;
        }

        [Benchmark]
        public int ListForToArray()
        {
            var data = _byteDataList.ToArray();

            int sum = 0;
            for (int i = 0; i < data.Length; ++i)
            {
                sum += data[i];
            }

            return sum;
        }

        [Benchmark]
        public int ListForLocalCached()
        {
            var data = _byteDataList;

            int sum = 0;
            for (int i = 0; i < data.Count; ++i)
            {
                sum += data[i];
            }

            return sum;
        }
    }
}