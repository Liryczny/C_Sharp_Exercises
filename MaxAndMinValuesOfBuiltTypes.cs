using System;
public class MaxAndMinValuesOfBuiltTypes
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BOOLEAN TYPE");
            Console.WriteLine("Boolean = {0} OR {1}\n", "True", "False");
            Console.WriteLine("INTEGRAL TYPES");
            Console.WriteLine("sByte = MAX:{0}, MIN:{1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("byte = MAX:{0}, MIN:{1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("short = MAX:{0}, MIN:{1}", short.MinValue, short.MaxValue);
            Console.WriteLine("uShort = MAX:{0}, MIN:{1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("int = MAX:{0}, MIN:{1}", int.MinValue, int.MaxValue);
            Console.WriteLine("uint = MAX:{0}, MIN:{1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("long = MAX:{0}, MIN:{1}", long.MinValue, long.MaxValue);
            Console.WriteLine("ulong = MAX:{0}, MIN:{1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("char\n");
            Console.WriteLine("FLOATING TYPE");
            Console.WriteLine("float = MAX:{0}, MIN:{1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double = MAX:{0}, MIN:{1}\n", double.MinValue, double.MaxValue);
            Console.WriteLine("STRING TYPE");
            Console.WriteLine("String = {0} {1}", "string", "type");
        }
    }

