using ClassLibrary;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestTriangle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 2, 2));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-5, 2, 2));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 0, 0));
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(5, 4, 3);
            var area = triangle.Area;
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void TestRightTriangle()
        {
            var triangle = new Triangle(5, 4, 3);
            var rightangled = triangle.RightAngled;
            Assert.AreEqual(true, rightangled);
        }

        [TestMethod]
        public void TestCircle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(0));
        }

        [TestMethod]
        public void TestCircleArea()
        {
            var circle = new Circle(10);
            var area = circle.Area;
            Assert.AreEqual(314.15926535897931, area);
        }
    }
}