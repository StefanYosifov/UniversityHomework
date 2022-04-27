using System;
using System.Collections;

namespace _01.homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ArrayList list = new ArrayList();
            foreach (char c in input)
            {

                list.Add((int)c - '0');
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                if ((int)list[i] == (int)list[i + 1])
                {
                    list.RemoveAt(i);
                    i--;
                }
            }

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}