using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Circle:BaseFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус не может быть меньше нуля.");
            Radius = radius;
        }

        public override double CalculateArea()
        {            
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
