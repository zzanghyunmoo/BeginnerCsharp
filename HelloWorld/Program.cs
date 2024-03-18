// using이란? 해당 "라이브러리"를 사용하겠다는 의미
// 라이브러리란? 비슷한 기능을 수행하는 함수들의 모음. c#에서는 네임스페이스. java는 package
using System;

namespace HelloWorld
{
    class Program
    {
        // Main 함수란? f(x) = Main(args)
        // 프로그램의 시작점(entry point), c#은 반드시 Main 함수부터 시작이 된다.
        // static이란? 전역 함수. oop랑은 관련 없는 친구
        // args? 매개변수, 외부로부터 Main 함수로 전달하는 데이터
        // void? 반환 값이 없는 함수.
        // int? 반환 값이 정수. 0 반환 시, 정상 종료를 의미함.
        static int Main(string[] args)
        {
            // Console.WriteLine = 입력 받은 문자열을 화면에 출력한 후 개행해주는 함수.
            // 함수란? 특정 기능을 수행하는 코드의 집합이다.
            Console.WriteLine("Hello World!");
            return 0;
        }
    }
}