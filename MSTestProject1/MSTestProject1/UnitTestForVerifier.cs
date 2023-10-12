// Test Methods for the Verifier class
//
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestProject1;

namespace MSTestProject1
{
    [TestClass]
    public class UnitTestForVerifier
    {
        [TestMethod]
        public void  TestIsPrime()
        {
            // Arrange
            var verifier = new Verifier();
            // Act
            var result = verifier.IsPrime(2);
            // Assert
            Assert.AreEqual(true, result);
        }
    }
}