// using이란? 해당 "라이브러리"를 사용하겠다는 의미
// 라이브러리란? 비슷한 기능을 수행하는 함수들의 모음. c#에서는 네임스페이스. java는 package
using System;

namespace HelloWorld
{
    class Program
    {
        // statement? 
        // 1. 한줄짜리 코드. 끝에 ; 있음.
        // 2. 여러 줄의 코드로 이루어진 블록. { } 로 감싸져 있음. ex) if
        // comment?
        // 코드와 관련된 내용을 메모할 때 사용. 컴파일 할 때 무시되는 문장. // /* */ 로 달 수 있음.
        static void Main(string[] args)
        {
            // (...) 에서 ...은 리터럴 상수! 
            // constant? 절대 변하지 않는 값. 숫자 뿐 아니라 문자까지 포함.
            Console.Write(30);        // int
            Console.WriteLine(30.1);  // double
            Console.WriteLine(30.2f); // float
            Console.Write(true);      // bool
            Console.Write('p');       // char
        }
    }
}