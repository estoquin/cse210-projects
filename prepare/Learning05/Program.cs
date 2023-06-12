using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("yellow", 4);
        Rectangle s2 = new Rectangle("blue", 5, 5);
        Circle s3 = new Circle("purple", 4);

        shapes.Add(s1);
        shapes.Add(s2);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Color: {s.GetColor()}");
            Console.WriteLine($"Area: {s.GetArea()}");
        }
    }
}