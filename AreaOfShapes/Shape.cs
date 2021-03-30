using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes
{
    public class Shape: IShape
    {
        public double Square { get; set; }

        public double GetSquare()
        {
            return Square;
        }
    };
}
