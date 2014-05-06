using System;

    public class Rectangle :Shape
    {
        //constructor
        public Rectangle(double width, double height)
            : base(width, height)
        {
 
        }

        //method
        public override double CalculateSurface()
        {
            double result = this.Width * this.Height;
            return result;
        }

    }

