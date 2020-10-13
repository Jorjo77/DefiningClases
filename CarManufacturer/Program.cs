using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car("Lambo", "Nai dobtia", 2010, 250, 9);
            Car golfa = new Car();
            Engine engine = new Engine(650, 1000);
            Tire[] tires = new Tire[4]
            {
                new Tire(2008, 1200),
                new Tire(2008, 1200),
                new Tire(2008, 1200),
                new Tire(2008, 1200),
            };
            Car toyota = new Car("t", "b", 1, 5, 4, engine, tires);
            car.Make = "WV";
            car.Model = "Mk3";
            car.Year = 1992;

            Console.WriteLine($"Make:{car.Make}\nModel:{car.Model}\nYear:{car.Year}");
        }
    }
}
