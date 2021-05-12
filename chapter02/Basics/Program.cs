using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Bob\tSmith";
            string verbatimString = @"C:\television\sony\bravia.txt";
            Console.WriteLine($"String with tab escape char: {str}\nthen a verbatim path {verbatimString}");
            System.Console.WriteLine("Using decimals:");
            decimal c = 0.1M;
            decimal d = 0.2M;

            if(c + d == 0.3M){
                System.Console.WriteLine("They are equal!");
            }else{
                System.Console.WriteLine("They are not equal!");
            }
        }
    }
}
