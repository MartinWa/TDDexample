using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TDDexamples
{
    public class IntegerStorage
    {
        private readonly List<int> _storage;

        public IntegerStorage()
        {
            _storage = new List<int>();
        }

        public void Add(int i)
        {
            _storage.Add(i);
        }

        public int CountStored()
        {
            return _storage.Count;
        }

        public string GetCommaSeparatedString()
        {
            var result = new List<string>();
            foreach (var i in _storage)
            {
                result.Add(i.ToString(CultureInfo.InvariantCulture));
            }
            return string.Join(",", result);
        }

        public int SumAllNumbers()
        {
            return _storage.Sum();
        }

        public bool IsStored(int checkedNumber)
        {
            return _storage.Contains(checkedNumber);
        }

        public int NumberAtIndex(int index)
        {
            return _storage[index];
        }
    }
}