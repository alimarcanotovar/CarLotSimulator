using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class 
        Program
    {
        static void Main(string[] args)
        {
            
            var carLot = new CarLot();
            carLot.ParkingLot = new List<Car>();
            var bmw = new Car();
            bmw.Make = "BMW";
            bmw.Year = 2022;
            bmw.Model = "Cool";
            bmw.EngineNoise = "Vroom Vroom";
            bmw.HonkNoise = "beep beep";
            bmw.IsDriveable = true;

            

            carLot.ParkingLot.Add(bmw);
            bmw.MakeEngineNoise();
            bmw.MakeHonkNoise();

            Console.WriteLine(CarLot.numberOfCars);

            var miniCooper = new Car(1999, "Mercedes", "Noice", "Vrooom", "beep boop", true);

            miniCooper.MakeEngineNoise();
            miniCooper.MakeHonkNoise();
            carLot.ParkingLot.Add(miniCooper);

            Console.WriteLine(CarLot.numberOfCars);

            var truck = new Car()
            {
                Make = "Truck",
                Year = 1991,
                Model = "wow",
                EngineNoise = "vrooooom",
                HonkNoise = "meep moop",
                IsDriveable = true,


            };
            truck.MakeEngineNoise();
            truck.MakeHonkNoise();
            carLot.ParkingLot.Add(truck);
            Console.WriteLine(CarLot.numberOfCars);


            foreach ( var car in carLot.ParkingLot)
            {
                Console.WriteLine($"year is {car.Year}, make is {car.Make}, and model is {car.Model}, and the engine sounds like ");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
            }




            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
