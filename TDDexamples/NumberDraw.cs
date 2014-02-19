using System;

namespace TDDexamples
{
    public class NumberDraw
    {
        private readonly IntegerStorage _numberStorage;

        public NumberDraw()
        {
            _numberStorage = new IntegerStorage();
        }

        public void DrawAndStore()
        {
            var rnd = new Random();
            _numberStorage.Add(rnd.Next(1,20));
        }

        public string GetCommaSeparatedDraws()
        {
            return _numberStorage.GetCommaSeparatedString();
        }
    }
}