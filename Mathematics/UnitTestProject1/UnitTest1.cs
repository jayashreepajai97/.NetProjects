using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public object InputConverter { get; private set; }

       
        [TestMethod]
        public void TwoNumbersDescendingAreSwapped()
        {
            // Arrange
            var input = "2 1";
            var expectedOutput = "1 2";
            // Act
            var actualOutput = InputConverter.ConvertInput(input);
            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

