using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses
{
    class Account
    {
        public static decimal Tax { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        public void PayTax()
        {
            //this.Balance -= Account.Tax; можем и да не го викаме((този Тах е един и същ за всички инстанции в класа!!!!!!!):
            this.Balance -= Tax;
        }
        public static string GetBankName ()
        {
            return "United Pesho Bank";
        }
    }
}
