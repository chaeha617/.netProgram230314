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
            Console.WriteLine("문자열을 입력해주세요.");
            string input = Console.ReadLine();
            string[] charArr = input.Split(' ');
            int[] word = new int[input.Length];
            for (int i = 0; i < charArr.Length; i++)
            {
                word[i] = charArr.Count(f => (charArr[i] == f));
                
            }
            int maxInd = Array.IndexOf(word, word.Max());
            Console.WriteLine("word : " + charArr[maxInd]+", time :" + word[maxInd]);
        }
    }
}
