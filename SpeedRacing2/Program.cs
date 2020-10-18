using System;
using System.Collections.Generic;

namespace SpeedRacing2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string model = inputInfo[0];
                double fuelAmount = double.Parse(inputInfo[1]);
                double fuelConsumpPer1km = double.Parse(inputInfo[2]);
                Car car = new Car(model, fuelAmount, fuelConsumpPer1km);
                cars.Add(car);
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] splittedCommand = command.Split();
                string carModel = splittedCommand[1];
                double distance = double.Parse(splittedCommand[2]);

                foreach (var car in cars)
                {
                    if (car.Model == carModel)
                    {
                        car.Drive(carModel, distance);
                        break;
                    }
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
