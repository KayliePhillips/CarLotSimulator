using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using CarLotSimulator;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE Create a seperate class file called Car
            //DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE The methods should take one string parameter: the respective noise property


            //DONE Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var carLot1 = new CarLot();
                      

            var car1 = new Car();
            car1.Year = 1990;
            car1.Make = "Ford";
            car1.Model = "Explorer";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "Beep, beep";
            car1.IsDriveable = false;

            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise();

            carLot1.ListOfCars.Add(car1);


            Console.WriteLine();

            var car2 = new Car()
            {
                Year = 2001,
                Make = "Toyota",
                Model = "Rave 4",
                EngineNoise = "Hmmmmm",
                HonkNoise = "Beeeeeeeeeeeeep",
                IsDriveable = true
            };

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise();

            carLot1.ListOfCars.Add(car2);

            Console.WriteLine();

            var car3 = new Car(2022, "Tesla", "Model S", "Purrrr", "Meep Meep", true);


            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise();

            carLot1.ListOfCars.Add(car3);

            Console.WriteLine();


            Console.WriteLine($"The cars currently on the lot are:");
            foreach (var car in carLot1.ListOfCars)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }


            //*************BONUS*************//

            // DONE Set the properties utilizing the 3 different ways we learned about, one way for each car


            //*************BONUS X 2*************//

            //DONE Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
