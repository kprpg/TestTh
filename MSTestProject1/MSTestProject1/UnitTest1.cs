
namespace MSTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            // Arrange
            var calculator = new Calculator();
            // Act
            var result = calculator.Add(1, 2);
            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            // Arrange
            var calculator = new Calculator();
            // Act
            var result = calculator.Subtract(1, 2);
            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestSubtractMethod2()
        {
            // Arrange
            var calculator = new Calculator();
            // Act
            var result = calculator.Subtract(2, 1);
            // Assert
            Assert.AreEqual(1, result);
        }
        
        [TestMethod]
        public void TestSubtractMethod3()
        {
            // Arrange
            var calculator = new Calculator();
            // Act
            var result = calculator.Subtract(2, 2);
            // Assert
            Assert.AreEqual(0, result);
        }

        
    }
}