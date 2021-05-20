using System;

namespace PrimeFactoryLib
{
    public class PrimeFactory
    {
        public string PrimeFactors(int number)
        {
            string numberToString = "";
            //initially checks if number is 1, 2, 3 or if it is prime
            if (number == 1 || number == 2 || number == 3)
            {
                return numberToString = $"1 * {number}";
            }else if(IsPrime(number)){
                return numberToString = $"1 * {number}";
            }

            while (number % 2 == 0)
            {
                numberToString += "2 ";
                number /= 2;
            }

           int factor = 3;
           while(factor * factor <= number){
               if(number % factor == 0){
                   numberToString += $"{factor} ";
                   number /= factor;
               }else{
                   factor += 2;
               }
           }

           if(number > 1) {numberToString += $"{number} ";}

            return numberToString;
        }


        /// <summary>
        /// Takes a number, gets its square root, and checks all numbers to see
        /// if they are a factor until it reaches teh square root
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true if a number is prime, false if not--></returns>
        bool IsPrime(int number)
        {

            bool CalculatePrime(int value)
            {
                var possibleFactors = Math.Sqrt(number);

                for (var factor = 2; factor <= possibleFactors; factor++)
                {
                    if (value % factor == 0)
                    {
                        return false;
                    }
                }

                return true; //returns true because no number could divide into it evenly

            }

            return number > 1 && CalculatePrime(number); //number cant be negative

        }
    }
}
