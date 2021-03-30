using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaOfShapes;

namespace AreaOfShapes.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleSquare1()
        {
            double radius = 3;
            double expected = 28.27;
            //act
            Circle circle1 = new Circle();
            double actual = circle1.GetSquare(radius);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
