using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeedRacing2
{
    public class Car
    {
        double travelDistance;
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TraveledDistance 
        {
            get
            {
                return this.travelDistance;
            } 
            set

            {
                travelDistance = value;
            }
        }

        public void Drive (string model, double distance)
        {
            double neededFuel = distance * FuelConsumptionPerKilometer;

                if (neededFuel <= FuelAmount)
                {
                    FuelAmount -= neededFuel;
                    TraveledDistance += distance;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
        }
    }
}
