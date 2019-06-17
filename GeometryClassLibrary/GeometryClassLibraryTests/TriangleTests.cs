using System;
using GeometryClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryClassLibraryTests
{
    [TestClass]
    public class TriangleTests
    {

        [DataRow(1, 1, 1)]
        [DataRow(1.618, 1.618, 1.618)]
        [DataRow(3, 4, 5)]
        [TestMethod]
        public void Constructor_Valid(double sideA, double sideB, double sideC)
        {
            // act
            Triangle triangle = new Triangle(sideA, sideB, sideC);
        }

        [DataRow(1, 1, 4)]
        [DataRow(1, 0, 1)]
        [DataRow(-1, 1, 1)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ArgumentOutOfRangeException(double sideA, double sideB, double sideC)
        {
            // act
            Triangle triangle = new Triangle(sideA, sideB, sideC);
        }

        [DataRow(3, 4, 5, true)]
        [DataRow(8, 14, 11.489, true)]
        [TestMethod]
        public void IsRightAngle_Valid(double sideA, double sideB, double sideC, bool expected)
        {
            // arrange
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // act
            triangle.CalcArea();
            bool actual = triangle.IsRightAngle;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRightAngle_NotRightAngle_False()
        {
            // arrange
            bool expected = false;
            double sideA = 3;
            double sideB = 6;
            double sideC = 4;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // act
            triangle.CalcArea();
            bool actual = triangle.IsRightAngle;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [DataRow(3, 4, 5, 6)]
        [DataRow(1, 1.5, 2, 0.73)]
        [TestMethod]
        public void CalcArea_Valid(double sideA, double sideB, double sideC, double expected)
        {
            // arrange
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // act
            double actual = Math.Round(triangle.CalcArea(), 5);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
