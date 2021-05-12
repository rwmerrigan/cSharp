using System;
using static System.Console;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;

            System.Console.WriteLine("Formatted Strings: \n");
            System.Console.WriteLine(
                format: "{0} apples costs {1:C}",
                arg0:numberOfApples,
                arg1: pricePerApple * numberOfApples
            );

            string formatted = string.Format(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
            );

            System.Console.WriteLine(formatted);

            System.Console.WriteLine("Interpolated Strings: \n");
            System.Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

            System.Console.WriteLine("Currency and N0 thousand separators for numbers");

            string applesText = "Apples";
            int applesCount = 1234;

            string bananasText = "Bananas";
            int bananasCount = 56789;

            System.Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count"
            );

            System.Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount
            );

            System.Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount
            );

            System.Console.WriteLine("Type your first name and press ENTER: ");
            string firstName = Console.ReadLine();

            System.Console.WriteLine("Type your age and press ENTER ");
            string age = Console.ReadLine();

            System.Console.WriteLine($"Hello {firstName}, you look good for {age}.");

            System.Console.WriteLine("Press any key combination: ");
            System.ConsoleKeyInfo key = ReadKey();
            System.Console.WriteLine();
            System.Console.WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
                arg0: key.Key,
                arg1: key.KeyChar,
                arg2: key.Modifiers
            );
        }
    }
}
