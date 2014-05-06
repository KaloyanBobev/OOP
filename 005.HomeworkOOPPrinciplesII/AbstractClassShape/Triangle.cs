using System;

     public class Triangle: Shape
    {
//constructor
         public Triangle(double width, double height)
             : base(width, height)
         { 
         }
         //method
         public override double CalculateSurface()
         {
            double result = (this.Width*this.Height)/2.0;
            return result;
         }
    }

