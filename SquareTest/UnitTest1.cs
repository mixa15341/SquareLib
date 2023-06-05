using SqureLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleTest1()
        {
            double x = 3;
            double expected = 28.274334;

            double y = Math.Round(Square.Circle(x), 6);
            Assert.AreEqual(expected, y);
        }

        [TestMethod]
        public void CircleTest2()
        {
            double x = 4.567;
            double expected = 65.525734;

            double y = Math.Round(Square.Circle(x), 6);
            Assert.AreEqual(expected, y);
        }
        [TestMethod]
        public void TriangleTest1()
        {
            double a = 4;
            double b = 5;
            double c = 6;
            double expected = 9.921567;

            double y = Math.Round(Square.Triangle(a, b, c), 6);
            Assert.AreEqual(expected, y);
        }
        [TestMethod]
        public void TriangleTest2()
        {
            double a = 5;
            double b = 3;
            double c = 4;
            bool expected = true;

            bool y = Square.IsRightTriangle(a, b, c);
            Assert.AreEqual(expected, y);
        }
    }
}