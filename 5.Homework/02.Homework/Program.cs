using System;
using System.Collections;

namespace _01.homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfList = int.Parse(Console.ReadLine());
            int[] arr = new int[sizeOfList];
            ArrayList list = new ArrayList();
            Random random = new Random();
            for (int i = 0; i < sizeOfList; i++)
            {
                int numberToAdd = random.Next(-10, 11);
                arr[i] = numberToAdd;
            }

            printingArr(arr);
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    list.Add(arr[i]);
                }
            }

            printingList(list);

        }

        private static void printingList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }

        private static void printingArr(int[] list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}