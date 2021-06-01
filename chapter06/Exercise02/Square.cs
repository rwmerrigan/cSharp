using System;

public class Square : Shape
{
    public Square(double height)
    {
        Height = height;
    }

    public override double Area()
    {
        return Height * Height;
    }
}
