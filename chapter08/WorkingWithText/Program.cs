using System;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "London";
            System.Console.WriteLine($"{city} is {city.Length} characters long.");
            System.Console.WriteLine($"First char is {city[0]} and third is {city[2]}.");
            
            string cities = "Paris,Berlin,Madrid,New York";
            string[] citiesArray = cities.Split(',');
            foreach (var item in citiesArray)
            {
                System.Console.WriteLine(item);
            }

            string fullName = "Alan Jones";
            int indexOfTheSpace = fullName.IndexOf(' ');

            string firstName = fullName.Substring(startIndex: 0, length: indexOfTheSpace);
            string lastName = fullName.Substring(startIndex: indexOfTheSpace + 1);

            System.Console.WriteLine($"{lastName}, {firstName}");

            string company = "Microsoft";
            bool startWithM = company.StartsWith("M");
            bool containsN = company.Contains("N");
            System.Console.WriteLine($"Starts with M: {startWithM}, contains an N: {containsN}");

            string recombined = string.Join(" => ", citiesArray);
            System.Console.WriteLine(recombined);

            string fruit = "Apples";
            decimal price = 0.39M;
            DateTime when = DateTime.Today;

            System.Console.WriteLine($"{fruit} cost {price:C} on {when:dddd}s.");
            System.Console.WriteLine(string.Format("{0} cost {1:C} on {2:dddd}s.", fruit, price, when));
        }
    }
}
