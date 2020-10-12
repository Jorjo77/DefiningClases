using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Human
    {
        private bool isAlive;
        public Human()
        {
            isAlive = true;
        }
        public Human(string name) : this()//така this() извиква празния конструктор и сега няма нужда да пиша isAlive (затова е закоментирано долу) и така може да ги чейнваме колкото си искаме.
        {
            //isAlive = true;
            Name = name;
        }
        public Human(string name, int age) : this(name)
        {
            //Name = name;
            //isAlive = true; тези няма смисъл пак да ги пиша защото горе ги има
            Age = age;//само това е ново и затова: добавям : this(name) и това ще мине през конструктора с name а той ще мине първо през празния конструктор this() и така по този начин преизползваме код и преизползваме конструктори.
        }
        public string Name { get; set; }
        public int Age { get; set; }

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
