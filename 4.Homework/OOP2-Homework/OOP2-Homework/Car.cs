using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Homework
{
    public class Car:MPS
    {
        public Car(string brand,string model,int year,string fueltype)
        {
            this.Brand = brand;
            this.Model = model;
            this.yearOfProduction = year;
            this.FuelType = fueltype;
        }
        public string FuelType { get; set; }
    }
}
