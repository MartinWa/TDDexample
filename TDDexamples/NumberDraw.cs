using NumberDatabaseExternalCode;

namespace TDDexamples
{
    public class NumberDraw
    {
        private readonly IRandomzer _randomzer;
        private readonly INumberDatabase _database;
        private readonly IIntegerStorage _integerStorage;

        public NumberDraw(IIntegerStorage integerStorage, IRandomzer randomzer, INumberDatabase numberDatabase)
        {
            _randomzer = randomzer;
            _integerStorage = integerStorage;
            _database = numberDatabase;
        }

        public int CountNumbersDrawn()
        {
            return _integerStorage.CountStored();
        }

        public void DrawAndStore()
        {
            _integerStorage.Add(_randomzer.Next(1, 20));
        }

        public string GetCommaSeparatedDraws()
        {
            return _integerStorage.GetCommaSeparatedString();
        }

        public int GetNumberAtIndex(int i)
        {
            return _integerStorage.NumberAtIndex(i);
        }

        public bool IsDrawn(int i)
        {
            return _integerStorage.IsStored(i);
        }

        public void StoreToDatabase()
        {
            _database.Store(_integerStorage.GetCommaSeparatedString());
        }
    }
}