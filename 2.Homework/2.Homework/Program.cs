using System;

namespace _2.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int total = 0;
            int[] arrOfNums = new int[wagons];
            for (int i = 0; i < wagons; i++)
            {
                int inputNums = int.Parse(Console.ReadLine());
                arrOfNums[i] = inputNums;
                total += inputNums;
            }

            Console.WriteLine(String.Join(" ", arrOfNums));
            Console.WriteLine(total);

        }
    }
}
