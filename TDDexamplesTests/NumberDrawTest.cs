using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDexamples;

namespace TDDexamplesTests
{
    [TestClass]
    public class NumberDrawTest
    {
        [TestMethod]
        public void DrawAndStore()
        {
            // Arrange
            var classUnderTest = new NumberDraw();

            // Act
            classUnderTest.DrawAndStore();

        }
    }
}
