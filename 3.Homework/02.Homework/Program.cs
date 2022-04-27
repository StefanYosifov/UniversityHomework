using System;

namespace _02.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loopCount = int.Parse(Console.ReadLine());
            int[] evenArr = new int[loopCount];
            int[] oddArr = new int[loopCount];


            int sizeEven = 1;
            int sizeOdd = 1;
            for (int i = 0; i < loopCount; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    evenArr[i] = input;
                    sizeEven++;
                }
                else
                {
                    oddArr[i] = input;
                    sizeOdd++;
                }
            }

            //Izbqgvane na prazni elementi
            Array.Resize(ref evenArr, sizeEven);
            Array.Resize(ref oddArr, sizeOdd);


            int sumEven = 0;
            int sumOdd = 0;
            foreach (var sum in evenArr)
            {
                sumEven += sum;
            }
            foreach (var sum in oddArr)
            {
                sumOdd += sum;
            }

            double result = Math.Abs(sumEven - sumOdd);
            Console.WriteLine(result);

            if (evenArr.Length == oddArr.Length)
            {

                Console.WriteLine($"The arrays are indentical.");
                Console.WriteLine($"Sum of first array = {sumEven}");
            }
            else
            {
                Console.WriteLine($"Not identical");
            }

        }
    }
}
