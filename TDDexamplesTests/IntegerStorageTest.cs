using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDexamples;

namespace TDDexamplesTests
{
    [TestClass]
    public class IntegerStorageTest
    {
        [TestMethod]
        public void AddInteger()
        {
            var classUnderTest = new IntegerStorage();

            classUnderTest.Add(10);
        }
    }
}
