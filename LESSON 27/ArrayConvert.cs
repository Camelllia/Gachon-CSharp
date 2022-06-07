using System;
using static System.Console;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 1, 4, 5 };
            // Collection - 모든 요소 변환
            char[] newArr = Array.ConvertAll(arr, Convert.ToChar);
            for (int i = 0; i < arr.Length; i++)
            {
                Write(newArr[i] + " ");
            }
        }
    }
}
