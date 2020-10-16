using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine, string color, string weight)
        {
            Model = model;
            this.engine = engine;
            Color = color;
            Weight = weight;
        }

        public string Model { get; set; }
        public Engine engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
    }
}
