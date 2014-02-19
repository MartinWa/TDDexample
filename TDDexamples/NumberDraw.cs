﻿using System;

namespace TDDexamples
{
    public class NumberDraw
    {
        private readonly IntegerStorage _numberStorage;

        public NumberDraw()
        {
            _numberStorage = new IntegerStorage();
        }

        public int CountNumbersDrawn()
        {
            return _numberStorage.CountStored();
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

        public int GetNumberAtIndex(int i)
        {
            return _numberStorage.NumberAtIndex(i);
        }
    }
}