using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDexamples;

namespace TDDexamplesTests
{
    [TestClass]
    public class IntegerStorageTests
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

        [TestMethod]
        public void A0002_NumberOfIntegersInIntegerStorage()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();
            classUnderTest.Add(5);
            classUnderTest.Add(78);

            // Act
            var numberOfElements = classUnderTest.Count();

            // Assert
            Assert.AreEqual(2,numberOfElements);
        }

        [TestMethod]
        public void A0003_StringOfAllCommaSeparatedIntegers()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();
            classUnderTest.Add(5);
            classUnderTest.Add(78);
            classUnderTest.Add(45);

            // Act
            var stringOfElements = classUnderTest.ToCommaSeparatedString();

            // Assert
            Assert.AreEqual("5,78,45", stringOfElements);
        }

        [TestMethod]
        public void A0004_SumOfAllStoredIntegers()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();
            classUnderTest.Add(5);
            classUnderTest.Add(78);
            classUnderTest.Add(45);

            // Act
            var sumOfElements = classUnderTest.Sum();

            // Assert
            Assert.AreEqual(5 + 78 + 45, sumOfElements);
        }

        [TestMethod]
        public void A0005_CheckIfIntegerExists()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();
            classUnderTest.Add(5);
            classUnderTest.Add(78);
            classUnderTest.Add(45);

            // Act
            var isStored = classUnderTest.IsStored(5);
            var isNotStored = classUnderTest.IsStored(79);

            // Assert
            Assert.IsTrue(isStored);
            Assert.IsFalse(isNotStored);
        }

        [TestMethod]
        public void A0006_GetIntegerAtIndex()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();
            classUnderTest.Add(5);
            classUnderTest.Add(78);
            classUnderTest.Add(45);

            // Act
            var numberAtIndex = classUnderTest.AtIndex(1);
            

            // Assert
            Assert.AreEqual(5, numberAtIndex);
        }

        [TestMethod]
        public void A0007_DeleteAllStoredNumbers()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();
            classUnderTest.Add(5);
            classUnderTest.Add(78);
            classUnderTest.Add(45);

            // Act
            var countBefore = classUnderTest.Count();
            classUnderTest.DeleteAll();
            var countAfter = classUnderTest.Count();

            // Assert
            Assert.AreEqual(3, countBefore);
            Assert.AreEqual(0, countAfter);
        }
    }
}
