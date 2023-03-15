using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Triangle:BaseFigure
    {
        public double SideOne { get; }
        public double SideTwo { get; }
        public double SideThree { get; }

        private Lazy<bool> rightAnged;
        public bool RightAngled { get { return rightAnged.Value; } }

        public Triangle(double s1, double s2, double s3)
        {
            if (s1 + s2 <= s3 || s1 + s3 <= s2 || s2 + s3 <= s1)
                throw new ArgumentException("Такой треугольник не существует.");
            SideOne = s1;
            SideTwo = s2;    
            SideThree = s3;
            rightAnged = new Lazy<bool>(IsRightAngled);
        }

        private bool IsRightAngled()
        {
            var sides = new[] { SideOne, SideTwo, SideThree }.OrderBy(n=>n).ToArray<double>();            
            return sides[2] * sides[2] == sides[1] * sides[1] + sides[0] * sides[0];
        }

        public override double CalculateArea()
        {
            double p = (SideOne + SideTwo + SideThree) / 2;
            return Math.Sqrt(p * (p - SideOne) * (p - SideTwo) * (p - SideThree));
        }
    }
}
