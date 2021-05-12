using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] typeNames = { "sbyte", "byte", "short",
                "ushort","int", "uint",
                "long", "ulong", "float",
                "double", "decimal"
            };

            int[] sizeOfTypes = { sizeof(sbyte), sizeof(byte), sizeof(short),
                sizeof(ushort), sizeof(int), sizeof(uint),
                sizeof(long), sizeof(ulong), sizeof(float),
                sizeof(double), sizeof(decimal)
            };

            object[] maxOfTypes = { sbyte.MaxValue, byte.MaxValue, short.MaxValue,
                ushort.MaxValue, int.MaxValue, uint.MaxValue,
                long.MaxValue, ulong.MaxValue, float.MaxValue,
                double.MaxValue, decimal.MaxValue
            };

            object[] minOfTypes = { sbyte.MinValue, byte.MinValue, short.MinValue,
                ushort.MinValue, int.MinValue, uint.MinValue,
                long.MinValue, ulong.MinValue, float.MinValue,
                double.MinValue, decimal.MinValue
            };
            WriteLine("-------------------------------------------------------------------------------");
            WriteLine("{0,-7} {1,-9:N0} {2,22} {3,30}", "Type", "Byte(s) of Memory", "Min", "Max");
            WriteLine("-------------------------------------------------------------------------------");

            for (int i = 0; i < 11; i++)
            {
                WriteLine("{0,-7} {1,-9:N0} {2,30} {3,30}", typeNames[i], sizeOfTypes[i], minOfTypes[i], maxOfTypes[i]);
            }

        }
    }
}
