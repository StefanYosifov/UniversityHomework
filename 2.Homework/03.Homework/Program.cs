using System;

namespace _03.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int number = int.Parse(Console.ReadLine());
            string numberAsText = number.ToString();


            int saveTheNumber = number;
            int multiplyOfTheDigits = 1;

            for (int i = 0; i < numberAsText.Length; i++)
            {
                int addToDigit = number % 10;
                multiplyOfTheDigits *= addToDigit;
                number /= 10;
            }

            Console.Write("Multiply of digits: ");
            Console.WriteLine(multiplyOfTheDigits);


            int size = 0;

            int[] resultArr = new int[size];
            for (int i = 1; i <= saveTheNumber; i++)
            {

                if (i % multiplyOfTheDigits == 0)
                {
                    size++;
                    Array.Resize(ref resultArr, size);
                    resultArr[resultArr.Length - 1] = i;
                    Console.WriteLine($"{i}/{multiplyOfTheDigits}");


                }


            }

            Console.WriteLine(String.Join(" ", resultArr));

        }
    }
}
