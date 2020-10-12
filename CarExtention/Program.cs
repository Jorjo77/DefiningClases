using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "WV";
            car.Model = "Mk3";
            car.Year = 1992;
            car.FuelConsumption = 12;
            car.FuelQuantity = 200;
            car.Drive(20);
            car.Drive(10);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
