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

            var gt1 = new GenericThing<int>();
            gt1.Data = 42;
            WriteLine($"GenericThing with an integer: {gt1.Process(42)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";
            WriteLine($"GenericThing with an integer: {gt2.Process("apple")}");

            string number1 = "4";
            System.Console.WriteLine("{0} squared is {1}",
                arg0: number1,
                arg1: Squarer.Square<string>(number1)
            );

            byte number2 = 3;

            System.Console.WriteLine("{0} squared is {1}",
                arg0: number2,
                arg1: Squarer.Square(number2)
            );

            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;

            System.Console.WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

            Employee john = new Employee
            {
                Name = "John Jones",
                DateOfBirth = new DateTime(1990, 7, 28),
            };
            john.EmployeeCode = "JJ001";
            john.HireDate = new DateTime(2014, 11, 23);
            john.WriteToConsole();
            System.Console.WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");
            System.Console.WriteLine(john.ToString());

            Employee aliceInEmployee = new Employee { Name = "Alice", EmployeeCode = "AA123" };

            Person aliceInPerson = aliceInEmployee;
            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole();
            System.Console.WriteLine(aliceInEmployee.ToString());
            System.Console.WriteLine(aliceInPerson.ToString());

            if (aliceInPerson is Employee)
            {
                System.Console.WriteLine($"{nameof(aliceInPerson)} IS an Employee");
                Employee explicitAlice = (Employee)aliceInPerson;
                //safely do something with explicitAlice
            }

            Employee aliceAsEmployee = aliceInPerson as Employee;

            if (aliceAsEmployee != null)
            {
                System.Console.WriteLine($"{nameof(aliceInPerson)} AS an Employee");
                //do something with aliceAsEmployee
            }

            try
            {
                john.TimeTravel(new DateTime(1999, 12, 31));
                john.TimeTravel(new DateTime(1950, 12, 25));
            }
            catch (PersonException ex)
            {
                System.Console.WriteLine(ex.Message); ;
            }

            string email1 = "pamela@test.com";
            string email2 = "ian&test.com";

            System.Console.WriteLine("{0} is a valid email adress: {1}",
            arg0: email1,
            arg1: email1.IsValidEmail());

            System.Console.WriteLine("{0} is a valid email adress: {1}",
            arg0: email2,
            arg1: email2.IsValidEmail());

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
