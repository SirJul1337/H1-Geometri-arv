using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Geometri_arv
{
    public class Trapez : Figure
    {
        private double sideB;
        private double sideC;
        private double sideD;








        public Trapez(double sideA,double b,double c) : base(sideA)
        {
            if (sideA < c)
            {
                sideA = c;
                sideC = sideA;
            }
            else
            {
                sideC = c;

            }
                sideB = b;
                sideD = sideB; //2 parallel sites
        }
        //Calculates Area
        public override double Area()
        {
            double s = FindS();
            double high = FindH(s);
            return (0.5 * (sideA + sideC) * high);
        }
        //Finds S
        public double FindS()
        {
            return ((sideA + sideB - sideC + sideD) / 2);
        }
        //Finds Height
        public double FindH(double s)
        {
            return (2 / (sideA - sideC) * Math.Sqrt(s * (s - sideA + sideC) * (sideA - sideB) * (sideA - sideD)));
        }
        //Calculates perimeter
        public override double Perimeter()
        {
            return (sideA + sideB + sideC + sideD);
        }


    }
}
