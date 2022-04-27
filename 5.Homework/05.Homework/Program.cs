using System;
using System.Collections;

namespace _02.ArrayL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int firstArr = int.Parse(Console.ReadLine());
            for (int i = 0; i < firstArr; i++)
            {
                int addIntoList = int.Parse(Console.ReadLine());
                list.Add(addIntoList);
            }
            ArrayList anotherList = new ArrayList();
            int secondArr = int.Parse(Console.ReadLine());
            for (int i = 0; i < secondArr; i++)
            {
                int addIntoList = int.Parse(Console.ReadLine());
                anotherList.Add(addIntoList);
            }

            for (int i = 0; i < list.Count; i++)
            {
                bool removeFromFirstList = false;
                for (int j = 0; j < anotherList.Count; j++)
                {
                    if ((int)list[i] == (int)anotherList[j])
                    {
                        anotherList.RemoveAt(j);
                        j--;
                        removeFromFirstList = true;

                    }
                }
                if (removeFromFirstList)
                {
                    list.RemoveAt(i);
                    i--;
                }

            }
            foreach (int i in anotherList)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }

        }
    }
}