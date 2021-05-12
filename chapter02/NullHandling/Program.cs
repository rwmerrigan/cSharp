using System;

namespace NullHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            //thisCannotBeNull = null;

            int? thisCouldBeNull = null;
            System.Console.WriteLine(thisCouldBeNull);
            System.Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;
            System.Console.WriteLine(thisCouldBeNull);
            System.Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
        }
    }
}
