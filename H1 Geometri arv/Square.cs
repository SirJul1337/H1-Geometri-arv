using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Geometri_arv
{
    public class Square : Figure
    {
        public Square(double sideA) : base(sideA)
        {
        }

        //Calculates Area of the square
        public override double Area()
        {
            return (sideA * sideA);
        }


        //Calculates Perimeter
        public override double Perimeter()
        {
            return (sideA * 4);
        }
    }
}
