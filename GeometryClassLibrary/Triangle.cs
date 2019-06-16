using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClassLibrary
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;
        private double p;
        private bool isRightAngle;
        private double cathetus_L;
        private double cathetus_R;
        private double hypotenuse;

        public double A { get => a; private set => a = value; }
        public double B { get => b; private set => b = value; }
        public double C { get => c; private set => c = value; }
        public double P { get => p; private set => p = value; }
        public bool IsRightAngle { get => isRightAngle; private set => isRightAngle = value; }
        public double Cathetus_L { get => cathetus_L; private set => cathetus_L = value; }
        public double Cathetus_R { get => cathetus_R; private set => cathetus_R = value; }
        public double Hypotenuse { get => hypotenuse; private set => hypotenuse = value; }

        public Triangle(double A, double B, double C)
        {
            if (((A > 0) && (B > 0) && (C > 0)) && ((A + B > C) || (A + C > B)||(B + C > A)))
            {
                this.A = A;
                this.B = B;
                this.C = C;
            }
            else
            {
                throw new ArgumentOutOfRangeException("All sides if triangle must be greater than zero and sum sizes of 2 sides must be greater than size of third side.");
            }

            if ((A * A) + (B * B) == (C * C))
            {
                IsRightAngle = true;
                Cathetus_L = A;
                Cathetus_R = B;
                Hypotenuse = C;
            }
            else if((A * A) * (C * C) == (B * B))
            {
                IsRightAngle = true;
                Cathetus_L = A;
                Cathetus_R = C;
                Hypotenuse = B;
            }
            else if((B * B) * (C * C) == (A * A))
            {
                IsRightAngle = true;
                Cathetus_L = B;
                Cathetus_R = C;
                Hypotenuse = A;
            }

            P = (A + B + C) / 2;
        }

        public override double Area()
        {
            if (IsRightAngle)
            {
                return (Cathetus_L * Cathetus_R) / 2;
            }
            else
            {
                return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            }
            
        }
    }
}
