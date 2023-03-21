using System;

namespace _230314
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("숫자 개수 입력: ");
            int input = int.Parse(Console.ReadLine());
            int[] arr = new int[input];
            for (int i = 0; i < input; i++)
            {
                Console.Write("숫자 입력: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            string numbersString = string.Join(" ", arr);
            Console.WriteLine(numbersString);
        }
    }
}