using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes
{
    public interface ICircle:IShape
    {
        double Radius { get; set; }
        double GetSquare(double radius);
    }
}
