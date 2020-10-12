using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            ////BankHelper helper = new BankHelper();Такова нещо НЯМА !!!
            ////тук this няма, защото няма инстанция!
            ////класа Math е добър пример за статичен клас
            //BankHelper.Name = "Pesho bank ";
            //BankHelper.CalculateDebt(55);
            //Math.Max(0, 2);
            //Program.Hello();//Директно на класа викаме статичния метод Hello()!
            ////и тъй като сме в същия клас може да не го викаме, то се сеща:

            ////static members: methods, fields, properties
            //Hello();

            Account account = new Account();
            Account.Tax = 500;
            account.Balance = 100;
            account.PayTax();
            Account account2 = new Account();
            account2.Balance = 1000;
            Account.Tax = 500;
            account.PayTax();
            account2.PayTax();
            Console.WriteLine(Account.GetBankName());
        }
        static void Hello()
        {

        }
    }
}
