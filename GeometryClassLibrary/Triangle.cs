using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClassLibrary
{
    public class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;
        private double _p;
        private bool _isRightAngle;
        private double _cathetus_L;
        private double _cathetus_R;
        private double _hypotenuse;

        public double A { get => _a; private set => _a = value; }
        public double B { get => _b; private set => _b = value; }
        public double C { get => _c; private set => _c = value; }
        public double p { get => _p; private set => _p = value; }                     // половинный периметр - удобней писать формулу Герона
        public bool IsRightAngle { get => _isRightAngle; private set => _isRightAngle = value; }
        public double Cathetus_L { get => _cathetus_L; private set => _cathetus_L = value; }
        public double Cathetus_R { get => _cathetus_R; private set => _cathetus_R = value; }
        public double Hypotenuse { get => _hypotenuse; private set => _hypotenuse = value; }

        public Triangle(double A, double B, double C)
        {
            if (((A > 0) && (B > 0) && (C > 0)) && ((A + B > C) || (A + C > B)||(B + C > A)))     // проверка является ли фигура треугольником
            {
                this.A = A;
                this.B = B;
                this.C = C;
            }
            else
            {
                throw new ArgumentOutOfRangeException("All sides if triangle must be greater than zero and sum sizes of 2 sides must be greater than size of third side.");
            }
            
            // проверка - является ли треугольник прямоугльным

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

            p = (A + B + C) / 2;      
        }

        public override double Area()
        {
            if (IsRightAngle)
            {
                return (Cathetus_L * Cathetus_R) / 2;        // если треугольник прямоугольный, то ищем площадь по более простой формуле
            }
            else
            {
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));   // нахождение площади по формуле Герона
            }
            
        }
    }
}
