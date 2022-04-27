using System;
using System.Collections.Generic;

namespace PyramidAndTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pyramid> figures = new List<Pyramid>();
            List<double> area = new List<double>();
            FillingInTheArrays(figures, area);
            

            double biggest = 0;
            foreach (var item in figures)
            {
                Pyramid pyramid = item;
                biggest = pyramid.Compare(area);
            }
            Console.WriteLine(biggest);
            foreach(var element in figures)
            {
                Console.WriteLine($"{element.FirstSide} {element.SecondSide}");
            }
            Pyramid pyramid = new Pyramid(0,0,0,0);
            pyramid.MutualArray(area, figures);

        }

        private static void FillingInTheArrays(List<Pyramid> figures, List<double> area)
        {
            int amountOfObjects = int.Parse(Console.ReadLine());
            for (int i = 0; i < amountOfObjects; i++)
            {
                double firstSide = double.Parse(Console.ReadLine());
                double secondSide = double.Parse(Console.ReadLine());
                double thirdSide = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Pyramid pyramid = new Pyramid(height, firstSide, secondSide, thirdSide);
                figures.Add(pyramid);
                area.Add(pyramid.Volume());
            }
        }
        
    }
}
