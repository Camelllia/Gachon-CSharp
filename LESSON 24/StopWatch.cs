using System;
using System.Diagnostics;
using System.Threading;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 타이머 객체 생성
            Stopwatch timer = new Stopwatch();
            // 시작
            timer.Start();
            // 3초 대기
            Thread.Sleep(3000);
            // 종료
            timer.Stop();

            // => 3.00xxxxx
            Console.WriteLine(timer.Elapsed.TotalSeconds);
        }
    }
}
