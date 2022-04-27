using System;
using System.Collections.Generic;

namespace _01.Bonus_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> saving = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }


            int maxCount = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                int start = 1;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        start++;
                    }
                    if (maxCount < start)
                    {
                        maxCount = start;
                    }
                }
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                int start = 1;
                int currentNumber = list[i];
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        start++;
                    }
                    if (start == maxCount && !saving.Contains(currentNumber))
                    {
                        saving.Add(currentNumber);
                    }
                }
            }

            while (saving.Count > 0)
            {
                int numToRemove = saving[saving.Count - 1];
                while (list.Contains(numToRemove))
                {
                    list.Remove(numToRemove);
                }
                saving.RemoveAt(saving.Count - 1);
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}