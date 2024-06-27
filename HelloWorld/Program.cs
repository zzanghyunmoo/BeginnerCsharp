using System;

namespace HelloWorld
{
    class Program
    {
        // Primitives Types. 기본 자료형. 하드웨어가 이해하는 자료형 
        static void Main(string[] args)
        {
            byte maxByte = byte.MaxValue;
            byte minByte = byte.MinValue;

            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine($"max byte: {maxByte}");
            Console.WriteLine($"min byte: {minByte}");
            Console.WriteLine($"max int: {maxInt}");
            Console.WriteLine($"min int: {minInt}");
            Console.WriteLine($"max long: {maxLong}");
            Console.WriteLine($"min long: {minLong}");
        }
    }
}