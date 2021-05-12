using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names;
            names = new string[4];
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            foreach (var name in names)
            {
                System.Console.WriteLine($"Name: {name}");
            }
        }
    }
}
