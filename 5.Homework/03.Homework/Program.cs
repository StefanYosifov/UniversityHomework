using System;
using System.Collections;

namespace _03.homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            ArrayList list = new ArrayList();
            foreach (var item in arr)
            {
                list.Add(item);
            }



            for (int i = 0; i < list.Count; i++)
            {
                string currentWord = list[i].ToString();
                foreach (char ch in currentWord)
                {
                    if (char.IsDigit(ch))
                    {
                        list.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }


        }
    }
}