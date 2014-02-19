using NumberDatabaseExternalCode;

namespace TDDexamplesTests
{
    public class NumberDatabaseStub : INumberDatabase
    {
        private string _data = "";
        public void Store(string stringToStore)
        {
            _data = stringToStore;
        }

        public string Retreive()
        {
            return _data;
        }
    }
}