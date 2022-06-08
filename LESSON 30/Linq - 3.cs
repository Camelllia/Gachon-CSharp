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
            int[] num = { 3, 1, 5 };
            // OrderBy + LinQ를 통한 오름차순 정렬
            IEnumerable<int> newArr = num.OrderBy(ele => ele);
            foreach (var ele in newArr)
            {
                // => 1 3 5
                Write(ele + " ");
            }
            // OrderByDescending + LinQ를 통한 내림차순 정렬
            IEnumerable<int> newArr2 = num.OrderByDescending(ele => ele);
            foreach (var ele in newArr2)
            {
                // => 5 3 1
                Write(ele + " ");
            }

            // 이외 메서드
            // Single() => null값이면 예외가 발생
            // SingleOrDefault() => 값이 없으면 null 반환
            // First() => 첫번째 요소 반환, 없으면 예외
            // FirstOrDefault() => 첫번째 요소 반환, 없으면 null
            // foreach + LinQ로 반복 출력 가능

            int[] arr = { 1, 2, 3, 4, 5 };
            // LinQ + Select를 사용하여 새로운 형태로 가공도 할 수 있음 (반환 타입은 항상 var 고정)
            var newArr3 = arr.Select(ele => ele * ele);
            foreach (var ele in newArr3)
            {
                // 1 4 9 16 25
                Write(ele + " ");
            }
        }
    }
}
