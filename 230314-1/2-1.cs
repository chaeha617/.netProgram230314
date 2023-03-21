using System;

namespace _230314_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                Console.WriteLine("0입니다!");
            }
            else if (input > 0)
            {
                Console.WriteLine("양수 입니다!");
            }
            else
            {
                Console.WriteLine("음수 입니다!");
            }
        }
    }
}

