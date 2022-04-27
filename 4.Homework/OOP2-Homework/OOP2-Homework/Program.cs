using System;



namespace OOP2_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfVehicles=int.Parse(Console.ReadLine());
            MPS[] arrayOfVehicles=new MPS[numberOfVehicles];

            for(int i=0; i < arrayOfVehicles.Length; i++)
            {
                string choice=Console.ReadLine();
                string brand = Console.ReadLine();
                string model = Console.ReadLine();
                int yearOfProduction = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    

                    case "Car":
                        string fuelType=Console.ReadLine(); 
                        arrayOfVehicles[i] = new Car(brand,model,yearOfProduction,fuelType);
                        break;
                    case "Truck":
                        double capacity=double.Parse(Console.ReadLine());
                        arrayOfVehicles[i] = new Truck(brand, model, yearOfProduction, capacity);
                        break;
                    case "Autobus":
                        int numberOfSeats = int.Parse(Console.ReadLine());
                        arrayOfVehicles[i]=new Autobus(brand,model,yearOfProduction,numberOfSeats);
                        break;
                }

            }


            int printAfterCertainYear = int.Parse(Console.ReadLine());
            foreach(var el in arrayOfVehicles)
            {
                if (el.yearOfProduction > printAfterCertainYear)
                {
                    Console.WriteLine($"{el.Brand} {el.Model} {el.yearOfProduction}");
                }
            }
        }
    }
    
}
