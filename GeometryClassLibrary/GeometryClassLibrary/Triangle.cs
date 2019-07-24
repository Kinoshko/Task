using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClassLibrary
{
    public class Triangle : Figure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private bool _isRightAngle;
        private double _cathetL;
        private double _cathetR;

        public double SideA { get => _sideA; private set => _sideA = value; }
        public double SideB { get => _sideB; private set => _sideB = value; }
        public double SideC { get => _sideC; private set => _sideC = value; }
        public bool IsRightAngle { get => _isRightAngle; private set => _isRightAngle = value; }
        private double CathetL { get => _cathetL; set => _cathetL = value; }
        private double CathetR { get => _cathetR; set => _cathetR = value; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (CheckIsTriangle(sideA, sideB, sideC))     
            {
                throw new ArgumentOutOfRangeException(
                "All sides of triangle must be greater than zero and sum sizes of 2 sides must be greater than size of third side.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalcArea()
        {
                double halfPer = (SideA + SideB + SideC) / 2;
                return Math.Round(Math.Sqrt(halfPer * (halfPer - SideA) * (halfPer - SideB) * (halfPer - SideC)), 2);
        }
        
        private bool CheckIsTriangle(double sideA, double sideB, double sideC)                 
        {
            if(((sideA <= 0) || (sideB <= 0) || (sideC <= 0)) || ((sideA + sideB <= sideC) || (sideA + sideC <= sideB) || (sideB + sideC <= sideA)))
            {
                return true;
            }
            return false;
        }

        private bool CheckRightAngle()                 // проверка - является ли треугольник прямоугльным
        {
            if ((Math.Round(SideA * SideA)) + (Math.Round(SideB * SideB)) == (Math.Round(SideC * SideC)))
            {
                IsRightAngle = true;
                CathetL = SideA;
                CathetR = SideB;
            }
            else if ((Math.Round(SideA * SideA)) + (Math.Round(SideC * SideC)) == (Math.Round(SideB * SideB)))
            {
                IsRightAngle = true;
                CathetL = SideA;
                CathetR = SideC;
            }
            else if ((Math.Round(SideB * SideB)) + (Math.Round(SideC * SideC)) == (Math.Round(SideA * SideA)))
            {
                IsRightAngle = true;
                CathetL = SideB;
                CathetR = SideC;
            }
            return IsRightAngle;
        }
    }
}
