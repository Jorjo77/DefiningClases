﻿using DefineAClassPerson;
using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Person pesho = new Person("Pesho", 20);
            //Console.WriteLine($"{pesho.Name} {pesho.Age}");

            //Person gosho = new Person("Gosho", 18);
            //Console.WriteLine($"{gosho.Name} {gosho.Age}");

            //Person stamat = new Person("Stamat", 43);
            //Console.WriteLine($"{stamat.Name} {stamat.Age}");

            //Person person1 = new Person();
            //Person person2 = new Person(12);
            //Person person3 = new Person("Stoyan", 24);

            int n = int.Parse(Console.ReadLine());

            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.AddMember(person);

            }

            //Person oldestPerson = family.GetOldestMember();
            Person[] people = family.GetPeople();
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
