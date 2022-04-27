using System;

namespace _04.LongestSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArr = int.Parse(Console.ReadLine());
            int[] nums = new int[sizeOfArr];
            for (int i = 0; i < sizeOfArr; i++)
            {
                Console.WriteLine($"{i + 1} Element: ");
                int numberToAdd = int.Parse(Console.ReadLine());
                nums[i] = numberToAdd;
            }
            int counter = 1;
            int largestCount = 0;
            int element = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > largestCount)
                {
                    largestCount = counter;
                    element = nums[i];
                }
            }
            for (int j = 1; j <= largestCount; j++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}