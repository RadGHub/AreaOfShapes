using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes
{
    public interface ITriangle:IShape
    {
        double FirstSide { get; set; }
        double SecondSide { get; set; }
        double ThirdSide { get; set; }
        bool IsRightTriangle(double firstside, double secondside, double thirdside);
        double GetSquare(double firstside, double secondside, double thirdside);
    }
}
