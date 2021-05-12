using System;

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
        }
    }
}
