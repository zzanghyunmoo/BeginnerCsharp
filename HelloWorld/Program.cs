using System;

namespace HelloWorld
{
    class Program
    {
        // Primitives Types. 기본 자료형. 하드웨어가 이해하는 자료형 
        static void Main(string[] args)
        {
            byte b = 0; // 8bit
            short s = 0; // 16bit
            int i = 0; // 32bit
            long l = 0L; // 64bit
            float f = 0f; // 32bit
            double d = 0d; // 64bit
            char c = 'a'; // 16bit (unicode
            bool bo = false; // 1bit  true or false

            Console.WriteLine($"byte: {b}");
            Console.WriteLine($"short: {s}");
            Console.WriteLine($"int: {i}");
            Console.WriteLine($"long: {l}");
            Console.WriteLine($"float: {f}");
            Console.WriteLine($"double: {d}");
            Console.WriteLine($"char: {c}");
            Console.WriteLine($"bool: {bo}");
        }
    }
}