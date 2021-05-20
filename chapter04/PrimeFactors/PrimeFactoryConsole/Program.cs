using System;
using PrimeFactoryLib;

namespace PrimeFactoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFactory num = new PrimeFactory();
            System.Console.WriteLine(num.PrimeFactors(245)); 
        }
    }
}
