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
            _storage = stringToStore;
        }

        public string Retreive()
        {
            return _storage;
        }
    }
}