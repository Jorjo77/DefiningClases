using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Pesho");
            Console.WriteLine(human.Name);
            human.Eat();
            human.Die();
            human.Eat();
        }
    }
}
