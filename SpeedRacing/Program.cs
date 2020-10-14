using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = inputInfo[0];
                double fuelAmount = double.Parse(inputInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(inputInfo[2]);
                Car currCar = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(currCar);
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="End")
                {
                    break;
                }
                string[] splittadCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = splittadCommand[1];
                double kilometersAmount = double.Parse(splittadCommand[2]);
                //Car car = cars.FirstOrDefault(x=>x.Model == model); ще връща модела!
                foreach (var car in cars)
                {
                    if (car.Model==model)
                    {
                        car.DistanceCalculator(model, kilometersAmount);
                        break;
                    }
                }

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
