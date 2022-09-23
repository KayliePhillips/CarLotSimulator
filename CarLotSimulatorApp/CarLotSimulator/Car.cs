using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    //DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    // Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property
    public class Car
    {
        public Car()
        {

            CarLot.numberOfCars++;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"My car sounds like {engineNoise}.");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"My car horn sounds like {HonkNoise}.");
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;


            CarLot.numberOfCars++;
        }
    }
   
    

    
}
