using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var bob = new Person();
            // bob.Name = "Bob Smith";
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

            // BankAccount.InterestRate = 0.012M; //store a shared value

            // var jonesAccount = new BankAccount();
            // jonesAccount.AccountName = "Mrs. Jones";
            // jonesAccount.Balance = 2400;

            // WriteLine(format: "{0} earned {1:C} interest.",
            // arg0: jonesAccount.AccountName,
            // arg1: jonesAccount.Balance * BankAccount.InterestRate
            // );

            // var gerrierAccount = new BankAccount();
            // gerrierAccount.AccountName = "Ms. Gerrier";
            // gerrierAccount.Balance = 98;

            // WriteLine(format: "{0} earned {1:C} interest.",
            // arg0: gerrierAccount.AccountName,
            // arg1: gerrierAccount.Balance * BankAccount.InterestRate
            // );

            // WriteLine($"{bob.Name} lives on {bob.HomePlanet}");

            // var blankPerson = new Person();

            // WriteLine(
            //     format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
            //     arg0: blankPerson.Name,
            //     arg1: blankPerson.HomePlanet,
            //     arg2: blankPerson.Instantiated
            // );

            // var gunny = new Person("Gunny", "Mars");

            // WriteLine(
            //     format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
            //     arg0: gunny.Name,
            //     arg1: gunny.HomePlanet,
            //     arg2: gunny.Instantiated
            // );

            // gunny.WriteToConsole();
            // WriteLine(gunny.GetOrigin());

            // (string, int) fruit = gunny.GetFruit();
            // var fruitNamed = gunny.GetFruit();

            // WriteLine($"{fruitNamed.Number}, {fruitNamed.Name} there are.");

            // var thing1 = ("Neville", 4);
            // WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

            // var thing2 = (gunny.Name, gunny.Children.Count);
            // WriteLine($"{thing2.Name} has {thing2.Count} children.");

            // //store return value in a tuple variable with two fields
            // (string name, int age) tupleWithNamedFields = GetPerson();
            // // tupleWithNamedFields.name
            // // tupleWithNamedFields.age

            // //deconstruct return value into two separate variables
            // (string name, int age) = GetPerson();

            // (string fruitName, int fruitNumber) = bob.GetFruit();
            // WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");
            // WriteLine(gunny.SayHello());
            // WriteLine(gunny.SayHello("Emily"));

            // WriteLine($"Default Optional Parameters {gunny.OptionalParameters()}");
            // WriteLine(gunny.OptionalParameters("Jump!", 98.5));
            // WriteLine(gunny.OptionalParameters(number: 52.7, command: "Hide!"));
            // WriteLine(gunny.OptionalParameters("Poke", active: false));

            // int a = 10;
            // int b = 20;
            // int c = 30;

            // WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            // gunny.PassingParameters(a, ref b, out c);
            // WriteLine($"After: a = {a}, b = {b}, c = {c}");

            // var sam = new Person
            // {
            //     Name = "Sam",
            //     DateOfBirth = new DateTime(1972, 1, 27)
            // };

            // //Properties
            // WriteLine(sam.Origin);
            // WriteLine(sam.Greeting);
            // WriteLine(sam.Age);

            // sam.FavoriteIceCream = "Chocolate Fudge";
            // WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
            // sam.FavoritePrimaryColor = "Red";
            // WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");

            // //Indexers
            // sam.Children.Add(new Person { Name = "Charlie" });
            // sam.Children.Add(new Person { Name = "Ella" });

            // WriteLine($"Sam's first child is {sam.Children[0].Name}");
            // WriteLine($"Sam's first child is {sam.Children[1].Name}");

            // WriteLine($"Sam's first child is {sam[0].Name}");
            // WriteLine($"Sam's first child is {sam[1].Name}");

            //Pattern Matching
            object[] passengers = {
                new FirstClassPassenger {AirMiles = 1_419},
                new FirstClassPassenger {AirMiles = 16_562},
                new BusinessClassPassenger(),
                new CoachClassPassenger {CarryOnKG = 25.7},
                new CoachClassPassenger {CarryOnKG = 0}
            };

            //c# 8 syntax
            // foreach (object passenger in passengers)
            // {
            //     decimal flightCost = passenger switch{
            //         FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
            //         FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
            //         FirstClassPassenger _ => 2000M,
            //         BusinessClassPassenger _ => 1000M,
            //         CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
            //         CoachClassPassenger _ => 650M,
            //         _ => 800M
            //     };
            //     WriteLine($"Flight costs {flightCost:C} for {passenger}");
            // }

            foreach (object passenger in passengers)
            {
                decimal flightCost = passenger switch
                {
                    //C# 9 syntax
                    FirstClassPassenger p => p.AirMiles switch
                    {
                        > 35000 => 1500M,
                        > 15000 => 1750M,
                        _ => 2000M
                    },
                    BusinessClassPassenger => 1000M,
                    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                    CoachClassPassenger => 650M,
                    _ => 800M

                };
                WriteLine($"Flight costs {flightCost:C} for {passenger}");
            }

            //fields here can only be set by an object initializer
            var Jeff = new ImmutablePerson
            {
                FirstName = "Jeff",
                LastName = "Winger"
            };

            //Jeff.FirstName = "Geoff";

            //makes car immutable like a value
            var car = new ImmutableVehicle
            {
                Brand = "Mazda MX-5 RF",
                Color = "Soul Red Crystal Metallic",
                Wheels = 4
            };
            //mutated copy
            var repaintedCar = car with { Color = "Polymetal Grey Metallic" };

            WriteLine("Original colow was {0}, new color is {1}.",
            arg0: car.Color, arg1: repaintedCar.Color);

            // var oscar = new ImmutableAnimal("Oscar", "Labrador");
            // var (who, what) = oscar; //calls deconstruct method
            // WriteLine($"{who} is a {what}.");

        }
    }
}
