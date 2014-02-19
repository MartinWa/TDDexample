namespace TDDexamples
{
    public interface IIntegerStorage
    {
        void Add(int i);
        int CountStored();
        string GetCommaSeparatedString();
        int SumAllNumbers();
        bool IsStored(int checkedNumber);
        int NumberAtIndex(int index);
        void ClearStorage();
    }
}