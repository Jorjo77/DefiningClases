using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Pesho");
            Human deadHumen = new Human();
            Console.WriteLine(deadHumen.Name);
            Console.WriteLine(human.Name);
            human.Eat();
            human.Die();
            human.Eat();
        }
    }
}
