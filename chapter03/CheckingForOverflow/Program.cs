using System;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            // checked
            // {
            //     int x = int.MaxValue - 1;
            //     System.Console.WriteLine($"Initial value: {x}");
            //     x++;
            //     System.Console.WriteLine($"After Incrementing: {x}");
            //     x++;
            //     System.Console.WriteLine($"After Incrementing: {x}");
            //     x++;
            //     System.Console.WriteLine($"After Incrementing: {x}");
            // }

            unchecked
            {
                int y = int.MaxValue + 1;
                System.Console.WriteLine($"Initial value: {y}");
                y--;
                System.Console.WriteLine($"Initial value: {y}");
                y--;
            }

            try
            {
                int x = int.MaxValue - 1;
                System.Console.WriteLine($"Initial value: {x}");
                x++;
                System.Console.WriteLine($"After Incrementing: {x}");
                x++;
                System.Console.WriteLine($"After Incrementing: {x}");
                x++;
                System.Console.WriteLine($"After Incrementing: {x}");

            }
            catch (OverflowException)
            {

                System.Console.WriteLine("The code overflowed but I caught the exception.");
            }

        }
    }
}
