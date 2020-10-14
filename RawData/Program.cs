using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string model = inputInfo[0];
                int engineSpeed = int.Parse(inputInfo[1]);
                int enginePower = int.Parse(inputInfo[2]);
                int cargoWeight = int.Parse(inputInfo[3]);
                string cargoType = inputInfo[4];

                Engine engine = new Engine(engineSpeed, enginePower);

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire[] tires = new Tire[4];
                int counter = 0;
                for (int j = 5; j < inputInfo.Length; j += 2)
                {
                    double tire1Pressure = double.Parse(inputInfo[j]);
                    int tire1Age = int.Parse(inputInfo[j + 1]);
                    Tire tire = new Tire(tire1Pressure, tire1Age);
                    tires[counter++] = tire;
                }
                //Тая хамалогия долу я заменихне с този фор горе и масива 
                //(масива и долу щеше да трябва)
                //double tire2Pressure = double.Parse(inputInfo[6]);
                //int tire2Age = int.Parse(inputInfo[7]);
                //double tire3Pressure = double.Parse(inputInfo[8]);
                //int tire3Age = int.Parse(inputInfo[9]);
                //double tire4Pressure = double.Parse(inputInfo[10]);
                //int tire4Age = int.Parse(inputInfo[11]);

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
                //"fragile" - print all cars whose cargo is "fragile" with a tire, whose pressure is < 1
                //"flamable" - print all of the cars, whose cargo is "flamable" and have engine power > 250

            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                var fragileCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(p => p.Pressure < 1)).ToList();

                foreach (var car in fragileCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                var flamable = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250).ToList();

                foreach (var car in flamable)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
