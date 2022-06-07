using System;
using static System.Console;

namespace _2022_Gachon_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[2];
                // 예외 직접 만들기
                throw new Exception();
                Exception e = new Exception();
                throw e;
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            finally
            {
                Write("Exit");
            }
        }
    }
}
