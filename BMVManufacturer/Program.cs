using System;
using CarManufacturer;

namespace BMVManufacturer
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManufacturer. е неймспеиса на който като сложим . точка и виждаме кои класове са в него, които можем да използваме.
            //от Dependencies (в проекта) мога с десен бутон да му кажа Add References и от там кой проект искаме да използваме от Салюшъна, а може и отвън да използваме онлайн неща от СОМ като: Library - та на Майкрософт или да вкараме код от другаде ! и вече using CarManufacturer работи, имам и Car, точно този от другия проект!!!
          // така с различните неймспейси можем да си управляваме класовете
            Car car = new Car();
            Console.WriteLine(car.Model);
        }
    }
}
