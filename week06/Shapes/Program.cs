using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("Blue", 2);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("Purple", 5, 4);
        shapes.Add(r1);

        Circle c1 = new Circle("Yellow", 5);
        shapes.Add(c1);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }


    }
}