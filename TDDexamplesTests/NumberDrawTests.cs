using System;
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
    }
}
