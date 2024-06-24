using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Console.WriteLine($"{x} + {y} = {x + y}");

            // constant는 대문자로 구성한다!
            const float PI = 3.14f;
            Console.WriteLine(PI);
        }
    }
}