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
            // 형식 지정 Generic 
            Stack<string> st = new Stack<string>();
            Queue<Char> q = new Queue<char>();
            List<int> list = new List<int>();


            // Enumerable Class로 Collection 생성
            string str = string.Join(",", Enumerable.Range(1, 4));
            // => 1,2,3,4
            Write(str);
        }
    }
}
