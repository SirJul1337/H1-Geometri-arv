using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Geometri_arv
{
    public class Triangle : Figure
    {

        private double sideB;
        private double sideC;
        public Triangle(double sideA, double b) : base(sideA)
        {
            sideC = FindC();
            sideB = b;

        }

        //Calculates c with pythagoras
        private double FindC()
        {
            return Math.Sqrt(Math.Pow(sideA,2)+Math.Pow(sideB,2))/2;
        }
        //Calculates Perimeter
        public override double Perimeter()
        {
            return (0.5 * sideA * sideB);
        }

        //Calculates Area
        public override double Area()
        {
            return (sideA + sideB + sideC);
        }
    }
}
