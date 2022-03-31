using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Geometri_arv
{
    public class Rectangle : Figure
    {
        private double sideB;

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public Rectangle(double sideA, double sideB) : base(sideA)
        {
            SideB = sideB;
        }

        //Calculates Perimeter
        public override double Perimeter()
        {
            return sideA *2 + sideB *2; 
        }

        //Calculates aREA
        public override double Area()
        {
            return sideA*sideB;
        }
    }
}
