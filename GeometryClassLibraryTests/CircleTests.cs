using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryClassLibrary;

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
        public void Constructor_ArgumentOutOfRangeExeption(double R)
        {
            // act
            Circle circle = new Circle(R);
        }

        [DataRow(1, Math.PI)]
        [DataRow(1.618, 8.224451)]
        [TestMethod]
        public void Area_Valid(double R, double expected)
        {
            // arrange
            Circle circle = new Circle(1);

            // act
            double actual = circle.Area();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
