using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Generic  + Delegate 사용하기 - Action은 반환 값 없을 때 사용
            Action<string> printf = WriteLine;

            printf("Generic  + Delegate");

            // 실행 결과 => Generic  + Delegate


            // Func은 (매개변수 타입, 리턴 타입)을 가짐
            Func<int, int> abs = Math.Abs;
            WriteLine(abs(-2));
            // 실행 결과 => 2

            // Predicate는 실행 결과를 boolean으로 리턴해줌
            Predicate<string> isNull = string.IsNullOrEmpty;
            WriteLine(isNull("no"));
            // 실행 결과 => false

            Predicate<Type> isPre = t => t.IsPrimitive;
            WriteLine(isPre(typeof(int)));
            // 실행 결과 => true
        }
    }
}
