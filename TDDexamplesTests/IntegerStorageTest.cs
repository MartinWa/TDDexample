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
            // Arrange
            var classUnderTest = new IntegerStorage();

            // Act
            classUnderTest.Add(10);
        }

        [TestMethod]
        public void CountStoredNumbers()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();
            classUnderTest.Add(10);
            classUnderTest.Add(4);

            // Act
            var result = classUnderTest.CountStored();

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}
