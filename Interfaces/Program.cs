using System;

namespace AbstractClInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle = new Triangle();
            triangle.SetEdge1(10);
            triangle.SetEdge2(14.89);
            triangle.SetEdge3(6.56);
            triangle.SetH1(5);
            PrintShapeDetails(triangle);

            Rectangle rectangle = new Rectangle();
            rectangle.SetEdge1(10);
            rectangle.SetEdge2(8);
            PrintShapeDetails(rectangle);

            Circle circle =new Circle();
            circle.SetRadiuss(8);
            PrintShapeDetails(circle);

        }

        static void PrintShapeDetails(IFigure shape)
        {
            Console.WriteLine("The perimeter of " + shape + " is " + shape.CalculatePerimeter());
            Console.WriteLine("The area of " + shape + " is " + shape.CalculateArea());
        }
    }
}
