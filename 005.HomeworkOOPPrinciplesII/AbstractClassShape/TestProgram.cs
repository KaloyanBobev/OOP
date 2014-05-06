/*Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
 * Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of
 * the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable
 * constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
 * Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.*/


using System;

class TestProgram
{
    static void Main()
    {

        Shape[] shapeArray =
            {
                new Triangle (5.2, 2.2),
                new Triangle(3.1, 4),
                new Triangle(9.1, 4.4),
                new Rectangle(2.3, 4.9),
                new Rectangle(3, 4.9),
                new Rectangle(3.22, 4.5),
                new Circle(4.6),
                new Circle(8.5),
                new Circle(3)
            };

        foreach (var s in shapeArray)
        {
            Console.WriteLine(s.CalculateSurface());
        }
    }
}

