using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidAndTriangle
{
    public class Triangle
    {
        public Triangle(double first,double second,double third)
        {

            this.FirstSide = first;
            this.SecondSide = second;
            this.ThirdSide = third;
        }

        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public double ThirdSide { get; set; }

    }
}
