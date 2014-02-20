using System;
using NumberDatabaseExternalCode;

namespace TDDexamples
{
    public class NumberDraw
    {
        private readonly IntegerStorage _integerStorage;
        private readonly Random _rand;
        private readonly NumberDatabase _database;

        public NumberDraw()
        {
            _integerStorage = new IntegerStorage();
            _rand = new Random();
            _database = new NumberDatabase();
        }

        public void DrawAndStoreNumber()
        {
            _integerStorage.Add(_rand.Next(1,20));
        }

        public string GetDrawnNumbers()
        {
            return _integerStorage.ToCommaSeparatedString();
        }

        public int CountDrawnNumbers()
        {
            return _integerStorage.Count();
        }

        public int GetNumberAtIndex(int index)
        {
            return _integerStorage.AtIndex(index);
        }

        public bool IsDrawn(int value)
        {
            return _integerStorage.IsStored(value);

        }

        public void WriteToDatabase()
        {
            _database.Store(_integerStorage.ToCommaSeparatedString());
        }
    }
}