using System;
using System.Collections.Generic;

namespace H1_Geometri_arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square2 = new Square(20);
            Square square3 = new Square(30);

            List<Figure> figures = new List<Figure>();

            Square square1 = new Square(10);
            Rectangle rectangle1 = new Rectangle(5, 10);
            Parallelogram parallelogram1 = new Parallelogram(3,5,20);
            Trapez trapez1 = new Trapez(10, 9, 8);
            Triangle triangle1 = new Triangle(10, 10);

            figures.Add(square1);
            figures.Add(rectangle1);
            figures.Add(parallelogram1);
            figures.Add(trapez1);
            figures.Add(triangle1);

            //Prints Perimeter of square 1
            Console.WriteLine("Prints Perimeter of square 1");
            Console.WriteLine(square1.Perimeter());

            //Prints Area of square 2
            Console.WriteLine("\nPrints Area of square 2");
            Console.WriteLine(square2.Area());


            //Prints Perimeter and Area of square 3
            Console.WriteLine(square3);


            //foreahc loop to print all figures in list
            foreach(Figure f in figures)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();

        }
    }
}
