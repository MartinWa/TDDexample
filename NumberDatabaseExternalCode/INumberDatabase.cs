namespace NumberDatabaseExternalCode
{
    public interface INumberDatabase
    {
        void Store(string stringToStore);
        string Retreive();
    }
}