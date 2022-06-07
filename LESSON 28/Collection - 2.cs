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
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("안", "녕");
            // Key 중복 허용 x
            dic.Add("안1", "녕1");

            dic.Remove("안1");

            // => 예외 발생 (Key 중복)
            try
            {
                dic.Add("안", "중복 안됨");
            }
            catch (Exception e)
            {
                Write(e.Message);
            }

            // 모든 요소 출력
            foreach (var items in dic)
            {
                WriteLine(items.Key + " " + items.Value);
            }

            // ContainsKey 메서드
            if (!dic.ContainsKey("json"))
            {
                dic.Add("json", "Json");
                WriteLine(dic["json"]);
            }
        }
    }
}
