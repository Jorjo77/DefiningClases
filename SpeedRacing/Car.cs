using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        public Car(string model, double travelledDistance)
        {
            Model = model;
            TravelledDistance = travelledDistance;
        }
        public Car(string model, double fuelAmount, double fuelConsumptiomPerKilomeyer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptiomPerKilomeyer = fuelConsumptiomPerKilomeyer;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptiomPerKilomeyer { get; set; }
        public double TravelledDistance { get; set; }

        public void DistanceCalculator(string model, double travelledDistance)
        {

            double usedFuel = travelledDistance * FuelConsumptiomPerKilomeyer;
            if (FuelAmount>= usedFuel)
            {
                Model = model;
                FuelAmount -= usedFuel;
                TravelledDistance += travelledDistance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }
    }
}
