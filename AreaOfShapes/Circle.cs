using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes
{
    public class Circle: Shape, ICircle
    {
        public double Radius { get; set; }
        public double GetSquare(double radius)
        {
            Radius = radius;
            Square = (Math.Pow(Radius, 2)*Math.PI);
            Square = Math.Round(Square, 2);
            return Square;
        }
    }
}
