using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDateAsString = Console.ReadLine();
            string secondDateAsString = Console.ReadLine();
            DateModifier dateModifier = new DateModifier();
            var result = dateModifier.GetDayDifference(firstDateAsString, secondDateAsString);

            Console.WriteLine(Math.Abs(result));
        }
    }
}
