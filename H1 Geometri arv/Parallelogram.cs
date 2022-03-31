using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Geometri_arv
{
    public class Parallelogram : Figure
    {
        private double sideB;
        private double vinkel;



        public Parallelogram(double sideA, double b, double v) : base(sideA)
        {
            sideB = b;
            vinkel = v;

        }
        //Calculate Area
        public override double Area()
        {
            return (sideA*sideB*Math.Sin(vinkel));
        }

        //Calculate Perimeter
        public override double Perimeter()
        {
            return (sideA + sideB);
        }
    }
}
