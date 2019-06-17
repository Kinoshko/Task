using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClassLibrary
{
    public class Circle : Figure
    {
        private double _radius;

        public double Radius { get => _radius; private set => _radius = value; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius of circle must be greater than zero.");

            }

            Radius = radius;
        }

        public override double CalcArea()
        {
            return Math.Round(Math.Pow(Radius, 2) * Math.PI, 2);
        }
    }
}
