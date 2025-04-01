using System;﻿

namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write subroutines to calculate the areas of 
            // Circle
            // Triangle
            // Rectangle
            // Pentagon
            // Octagon
			Console.WriteLine(areaOfCircle(1.5));
			Console.WriteLine(areaOfTriangle(3));
			Console.WriteLine(areaOfRectangle(2,5));
			Console.WriteLine(areaOfPentagon(15));
			Console.WriteLine(areaOfOctagon(12));
        }
        static double areaOfCircle(double r)
        {
 			return Math.PI*Math.Pow(r,2);
        }
		 static double areaOfTriangle(double sidelength)
        {
			 return (Math.Sqrt(3)) / 4 * Math.Pow(sidelength,2);
           
        } 
		static double areaOfRectangle(double length, float width)
        {
			return length*width;
        }
		static double areaOfPentagon(double sidelength)
        {
			return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(sidelength, 2);
        }
		 static double areaOfOctagon(double sidelength)
        {
			return (2 * (1 + Math.Sqrt(2))) * Math.Pow(sidelength, 2);
        }
		
    }
}
