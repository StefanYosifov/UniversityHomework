using System;

namespace _04.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                if (inputNum >= 10 && inputNum <= 99)
                {
                    if (inputNum % 2 == 0)
                    {
                        inputNum /= 10;
                        inputNum %= 10;
                    }
                    else
                    {
                        inputNum = inputNum % 10;
                    }
                }
                arr[i] = inputNum;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
