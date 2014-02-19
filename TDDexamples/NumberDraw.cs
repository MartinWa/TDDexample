﻿using System;
using NumberDatabaseExternalCode;

namespace TDDexamples
{
    public class NumberDraw
    {
        private readonly IntegerStorage _numberStorage;
        private readonly NumberDatabase _database;

        public NumberDraw()
        {
            _numberStorage = new IntegerStorage();
            _database = new NumberDatabase();
        }

        public int CountNumbersDrawn()
        {
            return _numberStorage.CountStored();
        }

        public void DrawAndStore()
        {
            var rnd = new Random();
            _numberStorage.Add(rnd.Next(1, 20));
        }

        public string GetCommaSeparatedDraws()
        {
            return _numberStorage.GetCommaSeparatedString();
        }

        public int GetNumberAtIndex(int i)
        {
            return _numberStorage.NumberAtIndex(i);
        }

        public bool IsDrawn(int i)
        {
            return _numberStorage.IsStored(i);
        }

        public void StoreToDatabase()
        {
            _database.Store(_numberStorage.GetCommaSeparatedString());
        }
    }
}