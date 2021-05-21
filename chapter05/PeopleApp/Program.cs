using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            bob.Name = "Bob Smith";
            // bob.DateOfBirth = new DateTime(1965, 12, 22);
            // bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            // bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            // bob.Children.Add(new Person { Name = "Alfred" });
            // bob.Children.Add(new Person { Name = "Zoe" });

            // var alice = new Person
            // {
            //     Name = "Alice Jones",
            //     DateOfBirth = new DateTime(1998, 3, 7)
            // };

            // WriteLine(
            //     format: "{0} was born on {1:dddd, d MMMM yyyy}, his favorite ancient wonder is {2}",
            //     arg0: bob.Name,
            //     arg1: bob.DateOfBirth,
            //     arg2: bob.FavoriteAncientWonder
            // );
            // WriteLine($"Bob's bucket list is {bob.BucketList}");
            // WriteLine(
            //     $"{bob.Name} has {bob.Children.Count} children: "
            // );

            // foreach (var Child in bob.Children)
            // {
            //     WriteLine($"  {Child.Name}");
            // }

            // WriteLine(
            //     format: "{0} was born on {1:dd MMM yy}",
            //     arg0: alice.Name,
            //     arg1: alice.DateOfBirth
            // );

            BankAccount.InterestRate = 0.012M; //store a shared value

            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;

            WriteLine(format: "{0} earned {1:C} interest.",
            arg0: jonesAccount.AccountName,
            arg1: jonesAccount.Balance * BankAccount.InterestRate
            );

            var gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Ms. Gerrier";
            gerrierAccount.Balance = 98;

            WriteLine(format: "{0} earned {1:C} interest.",
            arg0: gerrierAccount.AccountName,
            arg1: gerrierAccount.Balance * BankAccount.InterestRate
            );

            WriteLine($"{bob.Name} lives on {bob.HomePlanet}");

            var blankPerson = new Person();

            WriteLine(
                format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                arg0: blankPerson.Name,
                arg1: blankPerson.HomePlanet,
                arg2: blankPerson.Instantiated
            );

            var gunny = new Person("Gunny", "Mars");

            WriteLine(
                format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                arg0: gunny.Name,
                arg1: gunny.HomePlanet, 
                arg2: gunny.Instantiated
            );

            gunny.WriteToConsole();
            WriteLine(gunny.GetOrigin());

            (string, int) fruit = gunny.GetFruit();
            var fruitNamed = gunny.GetFruit();

            WriteLine($"{fruitNamed.Number}, {fruitNamed.Name} there are.");

            var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

            var thing2 = (gunny.Name, gunny.Children.Count);
            WriteLine($"{thing2.Name} has {thing2.Count} children.");

            // //store return value in a tuple variable with two fields
            // (string name, int age) tupleWithNamedFields = GetPerson();
            // // tupleWithNamedFields.name
            // // tupleWithNamedFields.age

            // //deconstruct return value into two separate variables
            // (string name, int age) = GetPerson();

            (string fruitName, int fruitNumber) = bob.GetFruit();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");
            WriteLine(gunny.SayHello());
            WriteLine(gunny.SayHello("Emily"));

            WriteLine($"Default Optional Parameters {gunny.OptionalParameters()}");
            WriteLine(gunny.OptionalParameters("Jump!", 98.5));
            WriteLine(gunny.OptionalParameters(number: 52.7, command: "Hide!"));
            WriteLine(gunny.OptionalParameters("Poke", active: false));
        }
    }
}
