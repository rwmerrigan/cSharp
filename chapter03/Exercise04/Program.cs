using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Enter a number between 0 and 255: ");
                string userByte1 = Console.ReadLine();
                byte userByte1Converted = Convert.ToByte(userByte1);
                System.Console.WriteLine("Enter another number between 0 and 255: ");
                string userByte2 = Console.ReadLine();
                byte userByte2Converted = Convert.ToByte(userByte2);
                int dividedBytes = userByte1Converted / userByte2Converted;
                System.Console.WriteLine($"{userByte1Converted} divided by {userByte2Converted} is {dividedBytes}");
            }
            catch (OverflowException)
            {
                System.Console.WriteLine("Number was not between 0-255");
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Invalid Input Entered");
            }

        }
    }
}
