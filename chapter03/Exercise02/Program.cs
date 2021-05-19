using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                checked
                {
                    int max = 500;
                    for (byte i = 0; i < max; i++)
                    {
                        System.Console.WriteLine(i);
                    }
                }

            }
            catch (OverflowException)
            {
                System.Console.WriteLine("Caught an Overflow, max will never be reached with byte data type");
            }
        }
    }
}
