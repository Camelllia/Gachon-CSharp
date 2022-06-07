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
            int[] nums = { 1, 2, 3, 4, 5 };
            // 화살표 람다 + where => nums의 원소 중 3 이상인 원소를 newNums에 삽입
            IEnumerable<int> newNums = nums.Where(num => num >= 3);
            var tmpSum = nums.Where(num => num <= 3).Sum(); // 6
            List<int> list = nums.Where(num => num <= 2).ToList();
            foreach (var ele in newNums)
            {
                // 3 4 5
                Write(ele + " ");
            }

            var cnt = nums.Where(num => num == 3).Count(); // 1 (num == 3인 것의 개수)
            bool flag = nums.Any(num => num == 3); // true (num == 3인 것이 하나라도 존재 => true 아님 false)
            bool allFlag = nums.All(num => num == 3); // false(num == 3이 모든 원소에 대해 참이면 true 아님 false)

            // 이외 메서드
            // 1. take(int n) => 앞의 n개의 원소 가져오기
            // 2. skip(int n) => 앞의 n개의 원소 스킵
            // 3. distinct() => 중복된 요소 제거 후 반환
        }
    }
}
