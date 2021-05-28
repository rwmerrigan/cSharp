using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };

            //call instance method
            var baby1 = mary.ProcreateWith(harry);
            baby1.Name = "Gary";

            //call static method
            var baby2 = Person.Procreate(harry, jill);
            //call an operator
            var baby3 = harry * mary;

            System.Console.WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            System.Console.WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            System.Console.WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            System.Console.WriteLine(format: "{0}'s first child is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name
            );

            System.Console.WriteLine($"5! is {Person.Factorial(5)}");

            harry.Shout += Harry_Shout;
            harry.Shout += Harry_Shout2; 
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            Person[] people = {
                new Person {Name = "Simon"},
                new Person {Name = "Jenny"},
                new Person {Name = "Adam"},
                new Person {Name = "Richard"}
            };

            System.Console.WriteLine("Initial list of people:");
            foreach (var person in people)
            {
                System.Console.WriteLine($"  {person.Name}");
            }

            // System.Console.WriteLine("Use Person's Icomparable implementation to sort:");
            // Array.Sort(people);
            // foreach (var person in people)
            // {
            //     System.Console.WriteLine($"  {person.Name}");
            // }

            System.Console.WriteLine($"User PersonComparer's Icomparer implementation to sort:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                System.Console.WriteLine($"  {person.Name}");
            }

            var t1 = new Thing();
            t1.Data = 42;
            System.Console.WriteLine($"Thing with an integer: {t1.Process(42)}");

            var t2 = new Thing();
            t2.Data = "apple";
            System.Console.WriteLine($"Thing with an integer: {t2.Process("apple")}");

        }

        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            System.Console.WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }

        private static void Harry_Shout2(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            System.Console.WriteLine($"{p.Name} is used in this method as well.");
        }
    }
}
