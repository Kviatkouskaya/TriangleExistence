using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class TriangleTests
    {
        [DataRow(1, 2, 7, false)]
        [DataRow(4, 3, 3, true)]
        [DataRow(6, 2, 2, false)]
        [DataRow(4, 3, 3, true)]
        [DataTestMethod]
        public void CheckExistance(int a, int b, int c, bool expected)
        {
            TriangleExistence.Triangle myTriangle = new TriangleExistence.Triangle(a, b, c);
            bool result = myTriangle.ExistTriangle();
            Assert.AreEqual(expected, result);
        }

        [DataRow(3, 3, 4, 10)]
        [DataRow(5, 5, 7, 17)]
        [DataRow(6, 6, 5, 17)]
        [DataTestMethod]
        public void CheckPerimeter(int a, int b, int c, int expected)
        {
            TriangleExistence.Triangle myTriangle = new TriangleExistence.Triangle(a, b, c);
            int result = myTriangle.CalculatePerimeter();
            Assert.AreEqual(expected, result);
        }

        [DataRow(16, 20, 33, 92.56349172324907)]
        [DataRow(17, 14, 16, 93.24162160752032)]
        [DataRow(6, 4, 5, 6.48074069840786)]
        [DataTestMethod]
        public void CheckGeronSquare(int a, int b, int c, double expected)
        {
            TriangleExistence.Triangle myTriangle = new TriangleExistence.Triangle(a, b, c);
            double result = myTriangle.CalculateGeronSquare();
            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class ProgramCheck
    {
        [DataRow("5,6,7", 5, 6, 7)]
        [DataRow("6,7,6", 6, 7, 6)]
        [DataTestMethod]
        public void CheckParseLine(string line, params int[] expected)
        {
            int[] result = TriangleExistence.Program.ParseLine(line);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
