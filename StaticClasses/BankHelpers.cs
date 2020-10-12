using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses
{
   static class BankHelper
    {
        //Много често неща които са общи и ще се използват често се именуват с Helper накрая.
        public static string Name { get; set; }
        public static void CalculateDebt(double income)
        {
            Console.WriteLine("Mnogo dylg");
        }
    }
}
