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

        }
        [TestMethod]
        public void CheckPerimeter()
        {
            TriangleExistence.Triangle myTriangle = new TriangleExistence.Triangle(4, 2, 2);
            int expected = 8;
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
}
