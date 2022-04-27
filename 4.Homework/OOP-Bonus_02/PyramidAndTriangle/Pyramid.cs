using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidAndTriangle
{
    public class Pyramid:Triangle
    {
        public Pyramid(double height,double first,double second,double third):base(first,second,third)
        {
            this.Height = height;
        }
        public double Height { get; set; }

        public List<double> list { get; set; }
        public List<Pyramid> listObjects { get; set; }
        public double halfPeremiter()
        {
            double p = (FirstSide + SecondSide + ThirdSide) / 2;
            return p;
        }
        public double Area()
        {
            double p=halfPeremiter();
            double area = Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
            return area;
        }

        public double Volume()
        {
            double area = Area();
            double height = Height;
            double volume = (area * height) / 2;
            return volume;
        }

        public double Compare(List<double> volumes)
        {
            double biggestVolume = 0;
            foreach(var item in volumes)
            {
                if (item > biggestVolume)
                {
                    biggestVolume= item;
                }
            }
            return biggestVolume;
        }

        public void MutualArray(List<double> list, List<Pyramid> secondList)
        {
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sortedArr = list.OrderBy(x => x).ToList();
                Console.WriteLine(String.Join(" ", sortedArr));
            }
            else if (choice == "2")
            {
                var sortedArr = secondList.OrderBy(x => x).ToList();
                Console.WriteLine(String.Join(" ", sortedArr));
            }
           
        }

    }
}
