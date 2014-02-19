using System.Collections.Generic;

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
    }
}