using System.Collections.Generic;
using System.Linq;

namespace TDDexamples
{
    public class IntegerStorage
    {
        private readonly List<int> _numbers;

        public IntegerStorage()
        {
            _numbers = new List<int>();
        }

        public void Add(int i)
        {
            _numbers.Add(i);
        }

        public int Count()
        {
            return _numbers.Count;
        }

        public string ToCommaSeparatedString()
        {
            return string.Join(",",_numbers);
        }

        public int Sum()
        {
            return _numbers.Sum();
           
        }

        public bool IsStored(int soughtValue)
        {
            return _numbers.Contains(soughtValue);
        }

        public int AtIndex(int index)
        {
            return _numbers[index - 1];
        }

        public void DeleteAll()
        {
            _numbers.Clear();
        }
    }
}