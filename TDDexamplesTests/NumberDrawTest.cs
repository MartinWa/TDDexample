using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var classUnderTest = new NumberDraw(new IntegerStoreageStub(), new RandomizerStub(new List<int> { 1 }), new NumberDatabaseStub());

            // Act
            classUnderTest.DrawAndStore();
        }

        [TestMethod]
        public void B0002_GetCommaSeparatedDraws()
        {
            // Arrange
            var classUnderTest = new NumberDraw(new RandomizerStub(new List<int> { 1, 2, 3 }), new NumberDatabaseStub());

            // Act
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            var result = classUnderTest.GetCommaSeparatedDraws();

            // Assert
            Assert.AreEqual("1,2,3", result);
        }

        [TestMethod]
        public void B0003_CountNumbersDrawn()
        {
            // Arrange
            var classUnderTest = new NumberDraw(new RandomizerStub(new List<int> { 1, 2, 3 }), new NumberDatabaseStub());

            // Act
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            var result = classUnderTest.CountNumbersDrawn();

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void B0004_CheckNumberAtIndex()
        {
            // Arrange
            var classUnderTest = new NumberDraw(new RandomizerStub(new List<int> { 1, 2, 3 }), new NumberDatabaseStub());

            // Act
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            var result = classUnderTest.GetNumberAtIndex(2);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void B0005_CheckIfNumberisDrawn()
        {
            // Arrange
            var classUnderTest = new NumberDraw(new RandomizerStub(new List<int> { 1, 2, 3 }), new NumberDatabaseStub());

            // Act
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            var resultTrue = classUnderTest.IsDrawn(1);
            var resultFalse = classUnderTest.IsDrawn(4);

            // Assert
            Assert.IsTrue(resultTrue);
            Assert.IsFalse(resultFalse);
        }

        [TestMethod]
        public void B0006_StoreToDatabase()
        {
            // Arrange
            var classUnderTest = new NumberDraw(new RandomizerStub(new List<int> { 1, 2, 3 }), new NumberDatabaseStub());

            // Act
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            classUnderTest.StoreToDatabase();
        }
    }
}
