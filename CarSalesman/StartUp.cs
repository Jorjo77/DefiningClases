using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string displacement = "n/a";
            string efficiency = "n/a";
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string model = inputInfo[0];
                int power = int.Parse(inputInfo[1]);

                if (inputInfo.Length == 4)
                {
                    displacement = inputInfo[2];
                    efficiency = inputInfo[3];
                }
                else if (inputInfo.Length == 3)
                {
                    char[] array = inputInfo[2].ToCharArray();
                    char firstSymbol = array[0];

                    if (char.IsDigit(firstSymbol))
                    {
                        displacement = inputInfo[2];
                    }
                    else
                    {
                        efficiency = inputInfo[2];
                    }
                }
                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string weight = "n/a";
                string color = "n/a";
                string[] inputData = Console.ReadLine().Split();
                string model = inputData[0];
                string engine = inputData[1];
                Engine currEngine = TakeEngine(engines, engine);

                if (inputData.Length == 4)
                {
                    weight = inputData[2];
                    color = inputData[3];
                }
                else if (inputData.Length == 3)
                {
                    char[] array = inputData[2].ToCharArray();
                    char firstSymbol = array[0];

                    if (char.IsDigit(firstSymbol))
                    {
                        weight = inputData[2];
                    }
                    else
                    {
                        color = inputData[2];
                    }
                }
                Car car = new Car(model, currEngine, color, weight);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.engine.Model}:");
                Console.WriteLine($"    Power: {car.engine.Power}");
                Console.WriteLine($"    Displacement: {car.engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }

        }

        private static Engine TakeEngine(List<Engine> engines, string engine)
        {
            foreach (var item in engines)
            {
                if (item.Model == engine)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
