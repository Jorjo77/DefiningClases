using System;

namespace EnumerationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string payment = "";
            Payment payment = Payment.Banck;
            Console.WriteLine(payment);

            Console.WriteLine($"GoToCanada: {(int)Payment.GoToCanada}");
            DoPayment(Payment.Cash);
            DoPayment(Payment.GoToCanada);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}: {(Payment)i}");
            }
        }
        static void DoPayment(Payment type)
        {
            if (type == Payment.Cash)
            {
                Console.WriteLine("Take all the money");
            }
            else if (type == Payment.GoToCanada)
            {
                Console.WriteLine("No more money");
            }
        }
    }
}
