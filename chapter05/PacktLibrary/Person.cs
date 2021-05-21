﻿using System;
using System.Collections.Generic;
using static System.Console;


namespace Packt.Shared
{
    public class Person : object
    {
        //fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        //public const string Species = "Homo Sapien"; best practice to avoid const
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        public Person()
        {
            //set default values for fields including read-only
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public string SayHello()
        {
            return $"{Name} says Hello!";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello! {name}'";
        }

        public (string Name, int Number) GetFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public string OptionalParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true
        )
        {
            return string.Format(
                format: "command is {0}, number is {1}, active is {2}",
                arg0: command, arg1: number, arg2: active
            );
        }

    }


}
