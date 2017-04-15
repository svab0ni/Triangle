using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleHomework;

namespace TriangleUnitTest
{
    [TestClass]
    public class TriangleTypeTest
    {
        [TestMethod]
        public void incorrectSideLengths()
        {
            Triangle obj = new Triangle();
            Assert.AreEqual("Wrong length of sides", obj.triangleType(-1, 2, 3));
        }

        [TestMethod]
        public void triangleInequality()
        {
            Triangle obj = new Triangle();
            Assert.AreEqual("Impossible to form Triangle with given sides", obj.triangleType(3,4,1));
        }

        [TestMethod]
        public void equilateralTriangle()
        {
            Triangle obj = new Triangle();
            Assert.AreEqual("Triangle is Equilateral", obj.triangleType(8, 8, 8));
        }

        [TestMethod]
        public void isoscalesTriangle()
        {
            Triangle obj = new Triangle();
            Assert.AreEqual("Triangle is Isoscales", obj.triangleType(3, 2, 3));
        }

        [TestMethod]
        public void scaleneTriangle()
        {
            Triangle obj = new Triangle();
            Assert.AreEqual("Triangle is Scalene", obj.triangleType(3,4,5));
        }

        [TestMethod]
        public void acuteTriangle()
        {
            Triangle obj = new Triangle();
            Assert.AreEqual("Triangle is acute", obj.triangleTypeByAngle(5, 5, 5));
        }

        [TestMethod]
        public void rightTriangle()
        {
            Triangle obj = new Triangle();
            Assert.AreEqual("Triangle is right", obj.triangleTypeByAngle(3, 4, 5));
        }

        [TestMethod]
        public void obtuseTriangle()
        {
            Triangle obj = new Triangle();
            Assert.AreEqual("Triangle is obtuse", obj.triangleTypeByAngle(5, 10, 14));
        }
    }
}
