using System;

namespace _1.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string riversWithEnoughElements = string.Empty;
            for (int i = 0; i < 7; i++)
            {
                string riverName = Console.ReadLine();
                if (riverName.Length == 4 || riverName.Length == 5)
                {
                    riversWithEnoughElements += riverName + "-";
                }
            }
            riversWithEnoughElements = riversWithEnoughElements.Remove(riversWithEnoughElements.Length - 1, 1);
            
            Console.WriteLine(riversWithEnoughElements);







           




 int total = 0;
            int min = int.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                if (firstNum == secondNum)
                {
                    total += firstNum;
                    continue;
                }


                if (firstNum < min)
                {
                    min = firstNum;
                }


                if (secondNum < min)
                {
                    min = secondNum;
                }


                total += firstNum + secondNum;
            }

            Console.WriteLine($"Average = {(double)total / 10}");
            Console.WriteLine($"Min = {min}");






            Console.Write($"Amount of inputs: ");
            int sizeOfLoop = int.Parse(Console.ReadLine());
            int evenCounter = 0;
            int oddCounter = 0;

            for (int i = 0; i < sizeOfLoop; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                if (inputNum % 2 == 0)
                {
                    evenCounter++;
                }
                else
                {
                    oddCounter++;
                }

                if (evenCounter >= 1 && oddCounter >= 1)
                {
                    Console.WriteLine($"Neither is correct, the input consist of both - even and odd numbers");
                    return;
                }
            }
            if (evenCounter == sizeOfLoop - 1)
            {
                Console.WriteLine($"Input consist of only even numbers");
            }
            else
            {
                Console.WriteLine($"Input consist of only odd numbers");
            }



           


            Random randomNum = new Random();
            int guessNumber = randomNum.Next(0, 50 + 1);

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Attempt {i + 1}: ");
                int input = int.Parse(Console.ReadLine());
                while (input < 0 || input > 50)
                {
                    Console.WriteLine($"Your input shall be in the range of 0 to 50");
                }

                if (input == guessNumber)
                {
                    Console.WriteLine($"Congratz you win, the correct number was {guessNumber}");
                    return;
                }
                else
                {
                    if (guessNumber > input)
                    {
                        Console.WriteLine($"Incorrect answer, try again. Aim higher");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect answer, try again. Aim lower");
                    }
                }

            }
            Console.WriteLine($"Oops you ran out of attempts");

        }
    }
}
