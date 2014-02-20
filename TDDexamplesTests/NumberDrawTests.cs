using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDexamples;

namespace TDDexamplesTests
{
    [TestClass]
    public class NumberDrawTests
    {
        [TestMethod]
        public void B0001_DrawNumber()
        {
            // Arrange
            var classUnderTest = new NumberDraw();

            // Act
            classUnderTest.DrawAndStoreNumber();

            // Assert
            //?

        }

        [TestMethod]
        public void B0002_CommaSeparatedStringOfDrawnNumbers()
        {
            // Arrange
            var classUnderTest = new NumberDraw();
            classUnderTest.DrawAndStoreNumber();
            classUnderTest.DrawAndStoreNumber();
            classUnderTest.DrawAndStoreNumber();

            // Act
            var stringOfDrawnNumbers = classUnderTest.GetDrawnNumbers();

            // Assert
            Assert.IsTrue(Regex.IsMatch(stringOfDrawnNumbers, @"\d+,\d+,\d+", RegexOptions.IgnoreCase));
        }

        [TestMethod]
        public void B0003_CountDrawnNumbers()
        {
            // Arrange
            var classUnderTest = new NumberDraw();
            classUnderTest.DrawAndStoreNumber();
            classUnderTest.DrawAndStoreNumber();
            classUnderTest.DrawAndStoreNumber();

            // Act
            var count = classUnderTest.CountDrawnNumbers();

            // Assert
            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void B0004_GetNumberAtIndex()
        {
            // Arrange
            var classUnderTest = new NumberDraw();
            classUnderTest.DrawAndStoreNumber();
            classUnderTest.DrawAndStoreNumber();
            classUnderTest.DrawAndStoreNumber();

            // Act
            var number = classUnderTest.GetNumberAtIndex(3);

            // Assert
            Assert.IsTrue(number > 0);
            Assert.IsTrue(number <= 20);
        }

        [TestMethod]
        public void B0005_NumberIsDrawn()
        {
            // Arrange
            var classUnderTest = new NumberDraw();
            classUnderTest.DrawAndStoreNumber();
            classUnderTest.DrawAndStoreNumber();
            classUnderTest.DrawAndStoreNumber();

            // Act
            var isDrawn = classUnderTest.IsDrawn(3);
            var isNotDrawn = classUnderTest.IsDrawn(14);


            // Assert
            Assert.IsTrue(isDrawn);
            Assert.IsFalse(isNotDrawn);
        }

        [TestMethod]
        public void B0006_DrawnNumbersStoredToDatabase()
        {
            // Arrange
            var classUnderTest = new NumberDraw();
            classUnderTest.DrawAndStoreNumber();
            classUnderTest.DrawAndStoreNumber();
            classUnderTest.DrawAndStoreNumber();

            // Act
            classUnderTest.WriteToDatabase();
           


            // Assert
            //?
           
        }
    }
}
