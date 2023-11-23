using System;
using RealAlgebra;
using ShapeAreaLib;
namespace RealAgebra
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a shape:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Triangle");

            char choice = Console.ReadKey().KeyChar;

            double area = 0;

            switch (choice)
            {
                case '1':
                    area = GetRectangleArea();
                    break;
                case '2':
                    area = GetSquareArea();
                    break;
                case '3':
                    area = GetCircleArea();
                    break;
                case '4':
                    area = GetTriangleArea();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine($"Area: {area}");
            Console.ReadKey();
        }

        static double GetRectangleArea()
        {
            Rectangle rectangle = new Rectangle();
            Console.Write("Enter length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            return rectangle.Area(length, width);
        }

        static double GetSquareArea()
        {
            ShapeAreaLib.Square square = new ShapeAreaLib.Square();
            Console.Write("Enter side length: ");
            double side = double.Parse(Console.ReadLine());
            return square.Area(side);
        }

        static double GetCircleArea()
        {
            ShapeAreaLib.Circle circle = new ShapeAreaLib.Circle();
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            return circle.Area(radius);
        }

        static double GetTriangleArea()
        {
            ShapeAreaLib.Triangle triangle = new ShapeAreaLib.Triangle();
            Console.Write("Enter base length: ");
            double baseLength = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            return triangle.Area(baseLength, height);
        }
    }

}
