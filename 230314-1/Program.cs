using System;

namespace _230314
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("10진수 숫자를 입력하세요: ");
            int number = int.Parse(Console.ReadLine());

            string binaryString = Convert.ToString(number, 2);

            Console.WriteLine("{0}의 이진수 표현: {1}", number, binaryString);
        }
    }
}