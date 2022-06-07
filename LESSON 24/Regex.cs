using System;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "1    2    3";
            // 정규 표현식
            var regex = new Regex("\\s+");
            // => 공백 여러개를 공백 하나로 치환
            string r = regex.Replace(s, " ");
            // => 1 2 3
            Console.WriteLine(r);
        }
    }
}
