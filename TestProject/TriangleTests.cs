using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class TriangleTests
    {
        [TestInitialize]

        [TestMethod]
        public void CheckExistance()
        {
            TriangleExistence.Triangle myTriangle = new TriangleExistence.Triangle(4, 2, 2);
            bool expected = false;
            bool result = myTriangle.TriangleCheck();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckExistance2()
        {
            TriangleExistence.Triangle myTriangle = new TriangleExistence.Triangle(4, 3, 2);
            bool expected = true;
            bool result = myTriangle.TriangleCheck();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckPerimeter()
        {
            TriangleExistence.Triangle myTriangle = new TriangleExistence.Triangle(4, 3, 2);
            int expected = 9;
            int result = myTriangle.TrianglePerimeter();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckGeronSquare()
        {
            TriangleExistence.Triangle myTriangle = new TriangleExistence.Triangle(16, 20, 33);
            double expected = 92.56349172324907;
            double result = myTriangle.GeronSquare();
            Assert.AreEqual(expected, result);
        }
    }
    [TestClass]
    public class ProgramCheck
    {
        [TestInitialize]

        [TestMethod]
        public void CheckParseLine()
        {
            int[] expected = { 5, 6, 7 };
            int[] result = TriangleExistence.Program.ParseLine("5,6,7");
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void CheckParseLine2()
        {
            int[] expected = { 5, 6, 10 };
            int[] result = TriangleExistence.Program.ParseLine("5,6,7");
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != result[i])
                {
                    Assert.AreNotEqual(expected[i], result[i]);
                }
            }
        }
    }
}
