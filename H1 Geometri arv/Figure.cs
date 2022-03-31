using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Geometri_arv
{
    public abstract class Figure
    {
        protected double sideA;
        public Figure(double a)
        {
            sideA = a;
        }

        //Abstract Method for area
        public abstract double Area();

        //Abstract Method for Perimeter
        public abstract double Perimeter();

        public override string ToString()
        {
            double area = Area();
            double perimeter = Perimeter();
            return "\n"+GetType().Name+"\nArea is: " + area + "\nPerimeter is: " + perimeter;
        }





    }


}
