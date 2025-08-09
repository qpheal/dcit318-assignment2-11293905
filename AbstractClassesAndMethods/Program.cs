using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter radius of circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle(radius);
        Console.WriteLine($"Area of the circle: {circle.GetArea()}");

        Console.Write("Enter length of rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter width of rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(length, width);
        Console.WriteLine($"Area of the rectangle: {rectangle.GetArea()}");
    }
}
