<<<<<<< HEAD
﻿using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before Parsing");
            Write("What is your age? ");
            string input = ReadLine();
            try
            {
                int age  = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch (FormatException)
            {
                WriteLine("The age you entered is not a valid number format.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After Parsing");
        }
    }
}
=======
﻿using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is your age? ");
            string input = ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch (FormatException)
            {
                WriteLine("The age you entered is not a valid number format.");
            }
            catch (OverflowException)
            {
                WriteLine("Age is too big or too small.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After Parsing");
        }
    }
}
>>>>>>> 43ec0982e6a156b951eeea5986cb43be046dcfa1
