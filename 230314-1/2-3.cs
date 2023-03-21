using System;
using System.Linq;

namespace _230314
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string answer = "";
            Console.WriteLine("숫자를 입력해주세요.");
            string input = Console.ReadLine();
            char[] charArr = input.ToCharArray();
            
            for (int i = 0; i < charArr.Length; i++)
            {
                if(charArr.Count(f => (charArr[i] == f)) == 1)
                {
                    answer += charArr[i];
                }
            }
            Console.WriteLine(answer);
        }
    }
}
