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
        public void CheckExistance(double a, double b, double c, bool expected)
        {
            double[] forCheck = { a, b, c };
            TriangleExistence.Triangle myTriangle = new TriangleExistence.Triangle(forCheck);
            bool result = myTriangle.ExistTriangle();
            Assert.AreEqual(expected, result);
        }

        [DataRow(3, 3, 4, 10)]
        [DataRow(5, 5, 7, 17)]
        [DataRow(6, 6, 5, 17)]
        [DataTestMethod]
        public void CheckPerimeter(double a, double b, double c, int expected)
        {
            double[] forCheck = { a, b, c };
            TriangleExistence.Triangle myTriangle = new TriangleExistence.Triangle(forCheck);
            double result = myTriangle.CalculatePerimeter();
            Assert.AreEqual(expected, result);
        }

        [DataRow(16, 20, 33, 117.82163426128497)]
        [DataRow(17, 14, 16, 104.3237149453565)]
        [DataRow(6, 4, 5, 9.921567416492215)]
        [DataTestMethod]
        public void CheckGeronSquare(double a, double b, double c, double expected)
        {
            double[] forCheck = { a, b, c };
            TriangleExistence.Triangle myTriangle = new TriangleExistence.Triangle(forCheck);
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
        public void CheckParseLine(string line, params double[] expected)
        {
            double[] result = TriangleExistence.Program.ParseLine(line);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
