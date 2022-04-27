using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Homework
{
    public class Autobus:MPS
    {
        public Autobus(string brand,string model,int fuel,int seatsCount)
        {
            this.Brand = brand;
            this.Model = model;
            this.yearOfProduction = fuel;
            this.SeatsCount = seatsCount;
        }
        public int SeatsCount { get; set; }
    }
}
