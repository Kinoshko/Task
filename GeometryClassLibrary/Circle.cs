using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClassLibrary
{
    public class Circle : Figure
    {
        private double r;

        public double R { get => r; private set => r = value; }

        public Circle(double R)
        {
            if(R > 0)
            {
                this.R = R;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Radius of circle must be greater than zero.");
            }
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
