﻿using System.Text.RegularExpressions;
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
            var classUnderTest = new NumberDraw();

            // Act
            classUnderTest.DrawAndStore();
        }

        [TestMethod]
        public void B0002_GetCommaSeparatedDraws()
        {
            // Arrange
            var classUnderTest = new NumberDraw();

            // Act
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            var result = classUnderTest.GetCommaSeparatedDraws();

            // Assert
            Assert.IsTrue(Regex.IsMatch(result, "\\d+,\\d+,\\d+", RegexOptions.IgnoreCase));
        }

        [TestMethod]
        public void B0003_CountNumbersDrawn()
        {
            // Arrange
            var classUnderTest = new NumberDraw();

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
            var classUnderTest = new NumberDraw();

            // Act
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            var result = classUnderTest.GetNumberAtIndex(2); // How to test this? (Rethorical question 1.)
        }

        [TestMethod]
        public void B0005_CheckIfNumberisDrawn()
        {
            // Arrange
            var classUnderTest = new NumberDraw();

            // Act
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            var result = classUnderTest.IsDrawn(5); // How to test this? (Rethorical question 2.)
        }

        [TestMethod]
        public void B0006_StoreToDatabase()
        {
            // Arrange
            var classUnderTest = new NumberDraw();

            // Act
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            classUnderTest.DrawAndStore();
            classUnderTest.StoreToDatabase(); // How to test this? (Rethorical question 3.)
        }
    }
}