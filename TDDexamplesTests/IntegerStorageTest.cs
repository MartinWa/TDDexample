﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        public void CommaSeparatedListOfAllStoredNumbers()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();
            classUnderTest.Add(10);
            classUnderTest.Add(4);
            classUnderTest.Add(9);

            // Act
            var result = classUnderTest.GetCommaSeparatedString();

            // Assert
            Assert.AreEqual("10,4,9", result);
        }

        [TestMethod]
        public void SumOfAllStoredNumbers()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();
            classUnderTest.Add(10);
            classUnderTest.Add(4);
            classUnderTest.Add(9);

            // Act
            var result = classUnderTest.SumAllNumbers();

            // Assert
            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void CheckIfNumberIsStored()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();
            classUnderTest.Add(10);

            // Act
            var resultPass = classUnderTest.IsStored(10);
            var resultFail = classUnderTest.IsStored(2);

            // Assert
            Assert.IsTrue(resultPass);
            Assert.IsFalse(resultFail);
        }

        [TestMethod]
        public void GetNumberAtIndex()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();
            classUnderTest.Add(10);
            classUnderTest.Add(4);
            classUnderTest.Add(9);

            // Act
            var result = classUnderTest.NumberAtIndex(1);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void ClearStorage()
        {
            // Arrange
            var classUnderTest = new IntegerStorage();
            classUnderTest.Add(10);
            classUnderTest.Add(4);
            classUnderTest.Add(9);

            // Act
            Assert.AreEqual(3, classUnderTest.CountStored());
            classUnderTest.ClearStorage();

            // Assert
            Assert.AreEqual(0, classUnderTest.CountStored());
        }
    }
}
