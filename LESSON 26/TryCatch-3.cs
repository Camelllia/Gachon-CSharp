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
                arr[100] = 33;
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
