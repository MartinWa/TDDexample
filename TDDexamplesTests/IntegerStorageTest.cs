using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDexamplesTests
{
    [TestClass]
    public class IntegerStorageTest
    {
        [TestMethod]
        public void A0001_StoreIntegers()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();

            // Act
            classUnderTest.Add(5);

            // Assert
            // ??
        }
    }
}
