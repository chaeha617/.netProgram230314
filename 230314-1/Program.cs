using System;

namespace _230314_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("단어를 입력해주세요.");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'o'|| input[i] == 'i' || input[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count + "개의 모음이 있습니다.");
        }
    }
}
