using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car("Lambo", "Nai dobria", 1 );

            car.FuelConsumption = 12;
            car.FuelQuantity = 200;
            car.Drive(20);
            car.Drive(10);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
