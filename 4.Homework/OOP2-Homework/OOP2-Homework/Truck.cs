using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Homework
{
    public class Truck:MPS
    {
        public Truck(string brand,string model,int year,double capacity)
        {
            this.Brand = brand;
            this.Model = model;
            this.yearOfProduction = year;
            this.Capactiy = capacity;
        }

        public double Capactiy { get; set; }
    }
}
