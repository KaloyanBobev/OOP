// Define class Circle and suitable
// constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.

using System;

    public class Circle: Shape
    {
    //constructor
        public Circle(double radius): base(radius)
        { 
        }

        //method
        public override double CalculateSurface()
        {
            double result = Math.PI * this.Width * this.Width;
            return result;
        }
    }

