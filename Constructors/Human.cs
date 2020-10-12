using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Human
    {
        private bool isAlive;
        public Human(string name)
        {
            isAlive = true;
            Name = name;
        }
        public string Name { get; set; }
        public void Eat()
        {
            if (isAlive)
            {
                Console.WriteLine("I am eating");
            }

        }
        public void Die()
        {
            isAlive = false;
        }
    }
}
