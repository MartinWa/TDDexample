using System.Threading;

namespace NumberDatabaseExternalCode
{
    public class NumberDatabase
    {
        private string _storage;

        public NumberDatabase()
        {
            _storage = "";
        }

        public void Store(string stringToStore)
        {
            Thread.Sleep(10000);
            _storage = stringToStore;
        }

        public string Retreive()
        {
            Thread.Sleep(10000);
            return _storage;
        }
    }
}