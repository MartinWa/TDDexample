using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NumberDatabaseExternalCode;
using TDDexamples;

namespace TDDexamplesTests
{
    [TestClass]
    public class NumberDrawTest
    {
        private Mock<IRandomzer> _randomizerMock;
        private Mock<INumberDatabase> _numberDatabaseMock;
        private Mock<IIntegerStorage> _integerStorageMock;
        private NumberDraw _classUnderTest;

        [TestInitialize]
        public void Initialize()
        {
            _randomizerMock = new Mock<IRandomzer>();
            _numberDatabaseMock = new Mock<INumberDatabase>();
            _integerStorageMock = new Mock<IIntegerStorage>();
            _classUnderTest = new NumberDraw(_integerStorageMock.Object, _randomizerMock.Object, _numberDatabaseMock.Object);
        }

        [TestMethod]
        public void B0001_DrawAndStore()
        {
            // Arrange
            const int start = 1;
            const int stop = 20;
            const int expected = 5;

            // Act
            _randomizerMock.Setup(rm => rm.Next(start, stop)).Returns(expected);
            _classUnderTest.DrawAndStore();

            // Assert
            _integerStorageMock.Verify(ism => ism.Add(expected));

        }

        [TestMethod]
        public void B0002_GetCommaSeparatedDraws()
        {
            // Arrange
            const string testValue = "ssttrriinngg";

            // Act
            _integerStorageMock.Setup(ism => ism.GetCommaSeparatedString()).Returns(testValue);
            var result = _classUnderTest.GetCommaSeparatedDraws();

            // Assert
            Assert.AreEqual(testValue, result);
        }

        [TestMethod]
        public void B0003_CountNumbersDrawn()
        {
            // Arrange
            const int testValue = 11;

            // Act
            _integerStorageMock.Setup(ism => ism.CountStored()).Returns(testValue);
            var result = _classUnderTest.CountNumbersDrawn();

            // Assert
            Assert.AreEqual(testValue, result);
        }

        [TestMethod]
        public void B0004_CheckNumberAtIndex()
        {
            // Arrange
            const int indexToLookAt = 2;
            const int expectedValue = 13;

            // Act
            _integerStorageMock.Setup(ism => ism.NumberAtIndex(indexToLookAt)).Returns(expectedValue);
            var result = _classUnderTest.GetNumberAtIndex(indexToLookAt);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void B0005_CheckIfNumberisDrawn()
        {
            // Arrange
            const int existingNumber = 1;
            const int notExistingNumber = 1;

            // Act
            _integerStorageMock.Setup(ism => ism.IsStored(existingNumber)).Returns(true);
            var resultTrue = _classUnderTest.IsDrawn(existingNumber);
            _integerStorageMock.Setup(ism => ism.IsStored(notExistingNumber)).Returns(false);
            var resultFalse = _classUnderTest.IsDrawn(notExistingNumber);

            // Assert
            Assert.IsTrue(resultTrue);
            Assert.IsFalse(resultFalse);
        }

        [TestMethod]
        public void B0006_StoreToDatabase()
        {
            // Arrange
            const string testValue = "ssttrriinngg";

            // Act
            _integerStorageMock.Setup(ism => ism.GetCommaSeparatedString()).Returns(testValue);
            _classUnderTest.StoreToDatabase();

            // Assert
            _numberDatabaseMock.Verify(db => db.Store(testValue));
        }
    }
}
