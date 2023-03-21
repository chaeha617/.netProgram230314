using System;

namespace _230314
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문자열을 입력하세요: ");
            string inputString = Console.ReadLine();

            string resultString = "";
            foreach (char c in inputString)
            {
                if (Char.IsDigit(c))
                {
                    resultString += c;
                }
                else
                {
                    resultString += Char.ToUpper(c);
                }
            }

            Console.WriteLine("결과: " + resultString);
        }
    }
}
