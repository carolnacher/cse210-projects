using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();

        
        shapes.Add(new Square("Blue", 4));
        shapes.Add(new Rectangle("Red", 6, 5));
        shapes.Add(new Circle("Green", 3));

        
        foreach (Shape shape in shapes)
        {
            
            string color = shape.Color;
            Console.WriteLine($"Color: {color}");

            
            double area = shape.GetArea();
            Console.WriteLine($"Area: {area}");

            Console.WriteLine(); 
        }

        Console.ReadLine(); 
    }
}

