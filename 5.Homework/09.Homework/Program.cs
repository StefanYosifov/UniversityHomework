using System;

namespace _06._2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            FillTheArray(matrix);
            PrintTheArray(matrix);

            int countNumsOverZero = 0;
            bool dilutedArr = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        countNumsOverZero++;
                    }
                    if (countNumsOverZero > matrix.Length / 2)
                    {
                        dilutedArr = true;
                        break;
                    }
                }

            }
            if (dilutedArr)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j % 2 == 0)
                        {
                            matrix[i, j] = 0;
                        }
                    }

                }
                Console.WriteLine($"More than half of the elements are >0. No changes have been made");
                Console.WriteLine($"======");
                PrintTheArray(matrix);
            }
            else
            {
                Console.WriteLine($"Less than half of the elements are < 0");
                Console.WriteLine($"======");
                PrintTheArray(matrix);
            }




        }

        private static void PrintTheArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void FillTheArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int numberToFill = int.Parse(Console.ReadLine());
                    matrix[i, j] = numberToFill;
                }
            }
        }
    }
}