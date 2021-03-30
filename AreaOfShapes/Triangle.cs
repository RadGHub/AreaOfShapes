using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfShapes
{
    public class Triangle:Shape, ITriangle
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
        double Cathet1 { get; set; }
        double Cathet2 { get; set; }
        double Hipotenuse { get; set; }

        public double GetSquare(double firstside, double secondside, double thirdside)
        {
            FirstSide = firstside;
            SecondSide = secondside;
            ThirdSide = thirdside;

            if ( IsRightTriangle(firstside,secondside,thirdside) )
            {
                Square = Cathet1 * Cathet2 / 2;
            }
            else 
            {
                double halfperimetr = (FirstSide + SecondSide + ThirdSide) / 2;
                Square = Math.Sqrt(halfperimetr * (halfperimetr-FirstSide)
                    * (halfperimetr-SecondSide)
                    * (halfperimetr-ThirdSide));//The Heron Formula;
            }
            Square = Math.Round(Square, 2);
            return Square;
        }

        public bool IsRightTriangle(double firstside, double secondside, double thirdside)
        {
            FirstSide = firstside;
            SecondSide = secondside;
            ThirdSide = thirdside;

            Hipotenuse = Math.Max(( Math.Max(FirstSide, SecondSide) ), ThirdSide);
            Cathet1 = Math.Min(( Math.Min(FirstSide, SecondSide) ), ThirdSide);
            Cathet2 = FirstSide + SecondSide + ThirdSide - Hipotenuse - Cathet1;

            if ( Math.Round(Math.Pow(Hipotenuse, 2), 2) == ( Math.Round(Math.Pow(Cathet1, 2), 2) + Math.Pow(Cathet2, 2) ))
                return true;
            else
                return false; 
        }
    }
}
