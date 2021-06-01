using System;

public class Circle : Shape
{
    public Circle(double height)
    {
        Height = height;
    }
    public override double Area()
    {
        var radius = Height / 2;
        return Math.PI * radius * radius;
    }
}