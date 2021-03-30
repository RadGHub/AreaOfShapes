using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaOfShapes;

namespace AreaOfShapes.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void IsRightTriangleTest1()
        {
            //arrange
            double c1 = 10.81665;
            double c2 = 6;
            double c3 = 9;
            //act
            Triangle triangle1 = new Triangle();
            bool actual = triangle1.IsRightTriangle(c1,c2,c3);
            //assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void TriangleRightSquare1()
        {
            //arrange
            double c1 = 6;
            double c2 = 9;
            double hip = 10.81665;
            double expected = 27;
            //act
            Triangle triangle1 = new Triangle();
            double actual = triangle1.GetSquare(hip, c2, c1);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TriangleSquare1()
        {
            double first = 2;
            double second = 3;
            double third = 4;
            double expected = 2.9;
            //act
            Triangle triangle1 = new Triangle();
            double actual = triangle1
                .GetSquare(first, second, third);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
