using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                
                if(i % 3 ==0 && i % 5 == 0){
                    System.Console.Write("FizzBuzz, ");
                }else if(i % 3 == 0 && i % 5 != 0){
                    System.Console.Write("Fizz, ");
                }else if(i % 3 != 0 && i % 5 == 0){
                    System.Console.Write("Buzz, ");
                }else{
                    System.Console.Write($"{i}, ");
                }
                if(i % 10 == 0){
                    System.Console.WriteLine();
                }
            }
        }
    }
}
