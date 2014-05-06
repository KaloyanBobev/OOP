// Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.

using System;

    public abstract class Shape
    {
        // fields
        private double width;
        private double height;

        //propertes
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value>= 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("The width is negative");
                }
                
            }
        }

        public double Height
        {
            get 
            {
                return this.height;
            }
            set 
            {
                if (value >= 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentException("The height is negative");
                }
            }
        }

        //constructor
         public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;

        }

          public Shape(double width)
         {
             this.Width = width;
         }

        //method
         abstract public double CalculateSurface();
               
    }

