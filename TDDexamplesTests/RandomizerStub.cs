using System;
using System.Collections.Generic;
using TDDexamples;

namespace TDDexamplesTests
{
    public class RandomizerStub : IRandomzer
    {
        private readonly List<int> _values;
        private int _currentIndex;

        public RandomizerStub(List<int> values)
        {
            _values = values;
            _currentIndex = 0;
        }
        public int Next(int start, int stop)
        {
            if (_currentIndex > _values.Count)
            {
                throw new IndexOutOfRangeException();
            }
            return _values[_currentIndex++];
        }
    }
}