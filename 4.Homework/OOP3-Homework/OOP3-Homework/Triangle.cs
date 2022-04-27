using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_Homework
{
    public class Triangle
    {

        private double firstSide;
        private double secondSide;
        private double thirdSide;

        public double FirstSide { get=>firstSide;}
        public double SecondSide { get=>secondSide; }
        public double ThirdSide { get=>thirdSide; }

        public void setSides()
        {
            this.firstSide = double.Parse(Console.ReadLine());
            this.secondSide = double.Parse(Console.ReadLine());
            this.thirdSide = double.Parse(Console.ReadLine());
        }

        public void checkForIntegrity()
        {
            if (firstSide + secondSide < thirdSide)
            {
                Console.WriteLine($"Two sides combined are less than the third one");
                
            }
            else if(secondSide + thirdSide < firstSide)
            {
                Console.WriteLine($"Two sides combined are less than the third one");
              
            }
            else if(thirdSide + firstSide < secondSide)
            {
                Console.WriteLine($"Two sides combined are less than the third one");
               
            }
        }


        public double calculateArea()
        {
            double semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
            double result=Math.Sqrt(semiPerimeter*(semiPerimeter-firstSide)*(semiPerimeter-secondSide)*(semiPerimeter-thirdSide));
            return result;
        }

    }
}
