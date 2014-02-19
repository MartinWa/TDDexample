using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NumberDatabaseExternalCode;
using TDDexamples;

namespace TDDexamplesTests
{
    [TestClass]
    public class NumberDrawTest
    {
        [TestMethod]
        public void B0001_DrawAndStore()
        {
            // Arrange
            var randomizerMock = new Mock<IRandomzer>();
            var numberDatabaseMock = new Mock<INumberDatabase>();
            var integerStorageMock = new Mock<IIntegerStorage>();
            var classUnderTest = new NumberDraw(integerStorageMock.Object, randomizerMock.Object, numberDatabaseMock.Object);

            // Act
            classUnderTest.DrawAndStore();

            // Assert
            integerStorageMock.Verify(ism => ism.Add(It.IsAny<int>()));

        }

        [TestMethod]
        public void B0002_GetCommaSeparatedDraws()
        {
            // Arrange
            var randomizerMock = new Mock<IRandomzer>();
            var numberDatabaseMock = new Mock<INumberDatabase>();
            var integerStorageMock = new Mock<IIntegerStorage>();
            const string testValue = "ssttrriinngg";
            var classUnderTest = new NumberDraw(integerStorageMock.Object, randomizerMock.Object, numberDatabaseMock.Object);

            // Act
            integerStorageMock.Setup(ism => ism.GetCommaSeparatedString()).Returns(testValue);
            var result = classUnderTest.GetCommaSeparatedDraws();

            // Assert
            Assert.AreEqual(testValue, result);
        }

        [TestMethod]
        public void B0003_CountNumbersDrawn()
        {
            // Arrange
            var randomizerMock = new Mock<IRandomzer>();
            var numberDatabaseMock = new Mock<INumberDatabase>();
            var integerStorageMock = new Mock<IIntegerStorage>();
            const int testValue = 11;
            var classUnderTest = new NumberDraw(integerStorageMock.Object, randomizerMock.Object, numberDatabaseMock.Object);

            // Act
            integerStorageMock.Setup(ism => ism.CountStored()).Returns(testValue);
            var result = classUnderTest.CountNumbersDrawn();

            // Assert
            Assert.AreEqual(testValue, result);
        }

        [TestMethod]
        public void B0004_CheckNumberAtIndex()
        {
            // Arrange
            var randomizerMock = new Mock<IRandomzer>();
            var numberDatabaseMock = new Mock<INumberDatabase>();
            const int indexToLookAt = 2;
            const int expectedValue = 13;
            var integerStorageMock = new Mock<IIntegerStorage>();
            var classUnderTest = new NumberDraw(integerStorageMock.Object, randomizerMock.Object, numberDatabaseMock.Object);

            // Act
            integerStorageMock.Setup(ism => ism.NumberAtIndex(indexToLookAt)).Returns(expectedValue);
            var result = classUnderTest.GetNumberAtIndex(indexToLookAt);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void B0005_CheckIfNumberisDrawn()
        {
            // Arrange
            var randomizerMock = new Mock<IRandomzer>();
            var numberDatabaseMock = new Mock<INumberDatabase>();
            var integerStorageMock = new Mock<IIntegerStorage>();
            const int existingNumber = 1;
            const int notExistingNumber = 1;
            var classUnderTest = new NumberDraw(integerStorageMock.Object, randomizerMock.Object, numberDatabaseMock.Object);

            // Act
            integerStorageMock.Setup(ism => ism.IsStored(existingNumber)).Returns(true);
            var resultTrue = classUnderTest.IsDrawn(existingNumber);
            integerStorageMock.Setup(ism => ism.IsStored(notExistingNumber)).Returns(false);
            var resultFalse = classUnderTest.IsDrawn(notExistingNumber);

            // Assert
            Assert.IsTrue(resultTrue);
            Assert.IsFalse(resultFalse);
        }

        [TestMethod]
        public void B0006_StoreToDatabase()
        {
            // Arrange
            var randomizerMock = new Mock<IRandomzer>();
            var numberDatabaseMock = new Mock<INumberDatabase>();
            var integerStorageMock = new Mock<IIntegerStorage>();
            const string testValue = "ssttrriinngg";
            var classUnderTest = new NumberDraw(integerStorageMock.Object, randomizerMock.Object, numberDatabaseMock.Object);

            // Act
            integerStorageMock.Setup(ism => ism.GetCommaSeparatedString()).Returns(testValue);
            classUnderTest.StoreToDatabase();

            // Assert
            numberDatabaseMock.Verify(db => db.Store(testValue));
        }
    }
}
