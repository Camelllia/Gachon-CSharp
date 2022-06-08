using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        // 매개변수도 전달 가능
        delegate void hello();

        static void Main(string[] args)
        {
            // 익명/무명 메서드
            hello say = delegate ()
            {
                Write("hello");
            };

            say();
            // 실행결과 => hello
        }
    }
}
