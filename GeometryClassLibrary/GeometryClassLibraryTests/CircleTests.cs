using System;
using GeometryClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace GeometryClassLibraryTests
{
    [TestClass]
    public class CircleTests
    {
        [DataRow(1)]
        [DataRow(1.618)]
        [TestMethod]
        public void Constructor_Valid(double R)
        {
            // act
            Circle circle = new Circle(R);
        }

        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(null)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ArgumentOutOfRangeExeption(double radius)
        {
            // act
            Circle circle = new Circle(radius);
        }

        [DataRow(1, 3.14)]
        [DataRow(5.5, 95.03)]
        [TestMethod]
        public void CalcArea_Valid(double radius, double expected)
        {
            // arrange
            Circle circle = new Circle(radius);

            // act
            double actual = Math.Round(circle.CalcArea(), 5);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
