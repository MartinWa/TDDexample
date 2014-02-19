using System.Threading;

namespace NumberDatabaseExternalCode
{
    public class NumberDatabase : INumberDatabase
    {
        private string _storage;

        public NumberDatabase()
        {
            _storage = "";
        }

        public void Store(string stringToStore)
        {
            Thread.Sleep(2000);
            _storage = stringToStore;
        }

        public string Retreive()
        {
            Thread.Sleep(6000);
            return _storage;
        }
    }
}