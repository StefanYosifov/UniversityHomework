using System;

namespace _05.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountOfInputs = int.Parse(Console.ReadLine());
            List<String> arr = new List<string>();
            for (int i = 0; i < amountOfInputs; i++)
            {
                string input = Console.ReadLine();
                arr.Add(input);
            }


            arr.Sort();

            int savingArrSize = arr.Count();
            List<string> newArr = new List<string>();
            for (int loops = 0; loops < savingArrSize; loops++)
            {
                int current = 0;
                int max = 0;
                string textToAdd = " "; // String.empty dava bugove


                //Vzimame elementa ot tozi cikul
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        current++;
                    }
                    else
                    {
                        current = 0;
                    }
                    if (max < current)
                    {
                        max = current;
                        textToAdd = arr[i];
                    }
                }
                //Da nqma buga, kudeto se dobavqt prazni elementi
                if (textToAdd == " ")
                {
                    continue;
                }

                //Dobavq vsichki elementi, koito sa ravni na promenlivata i maha ot drugiq masiv da nqma 20 ednakvi chisla
                for (int j = 0; j < max + 1; j++)
                {
                    newArr.Add(textToAdd);
                    arr.Remove(textToAdd);
                }
            }


            //Dobavq elementite, koito se povtarqt samo vednuj
            for (int i = 0; i < arr.Count; i++)
            {
                newArr.Add(arr[i]);
            }

            Console.WriteLine(String.Join(" ", newArr));
        }
    }
}
