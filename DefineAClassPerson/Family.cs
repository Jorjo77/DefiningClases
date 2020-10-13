using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefineAClassPerson
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
            //// 1 foreach/ min max value
            ////2 linq
            // подобно дългото би изглеждало на С++, а долу късото е С#!
            //int maxAge = int.MinValue;
            //Person oldestPerson = null;

            //foreach (var person in People)
            //{
            //    var currentAge = person.Age;
            //    if (currentAge>maxAge)
            //    {
            //        maxAge = currentAge;
            //        oldestPerson = person;
            //    }
            //}
            //return oldestPerson;
            // по кратко:
            //Person oldestPerson = People.OrderByDescending(x => x.Age).First();
            //return oldestPerson;
            // а може и по кратко: return People.OrderByDescending(x => x.Age).First(); или:
            => People.OrderByDescending(x => x.Age).First();
        
        public Person[] GetPeople()
        {
            var people = People.Where(x => x.Age > 30).OrderBy(x => x.Name)
                .ToArray();
            return people;
        }
    }
}
