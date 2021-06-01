using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2, 2);
            Circle c = new Circle(3);
            Square s = new Square(2);

            System.Console.WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area()}");
            System.Console.WriteLine($"Circle H: {c.Height}, Area: {c.Area()}");
            System.Console.WriteLine($"Rectangle H: {r.Height}, Area: {r.Area()}");
        }
    }
}
