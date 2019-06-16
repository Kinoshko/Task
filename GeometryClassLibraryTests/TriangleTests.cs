using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryClassLibrary;

namespace GeometryClassLibraryTests
{
    [TestClass]
    public class TriangleTests
    {

        [DataRow(1 , 1, 1)]
        [DataRow(1.618, 1.618, 1.618)]
        [DataRow(3, 4, 5)]
        [TestMethod]
        public void Constructor_Valid(double a, double b, double c)
        {
            // act
            Triangle triangle = new Triangle(a, b, c);
        }

        [DataRow(1, 1, 4)]
        [DataRow(1, 0, 1)]
        [DataRow(-1, 1, 1)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ArgumentOutOfRangeException(double a, double b, double c)
        {
            // act
            Triangle triangle = new Triangle(a, b, c);
        }

        [DataRow(3, 4, 5, true)]
        [DataRow(8, 14, 11.4891, true)]
        [TestMethod]
        public void Constructor_IsRightAngle_Valid(double a, double b, double c, bool expected)
        {
            // arrange
            Triangle triangle = new Triangle(a, b, c);

            // act
            bool actual = triangle.IsRightAngle;
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Constructor_IsNotRightAngle_Valid()
        {
            // arrange
            bool expected = false;
            double a = 1;
            double b = 1;
            double c = 4;
            Triangle triangle = new Triangle(a, b, c);

            // act
            bool actual = triangle.IsRightAngle;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [DataRow(3, 4, 5, 6)]
        [DataRow(1, 1.5, 2, 0.726184)]
        [TestMethod]
        public void Area_Valid(double a, double b, double c, double expected)
        {
            // arrange
            Triangle triangle = new Triangle(a, b, c);

            // act
            double actual = triangle.Area();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
