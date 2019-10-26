using System;
using System.Reflection;

namespace HWDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] car = new Car[5];
            car[0] = new Car();
            car[1] = new Car();
            car[2] = new Car();
            car[3] = new Car("Хетчбек", "бензин", 1600);
            car[4] = new Car("GTV", 999999.99, true);
            Console.WriteLine("Диамерт колесного диска (13..22)?");
            string D = Console.ReadLine();
            car[0].choiceDisk(D);
            Console.WriteLine("Всего покрышек - " + car[0].MoreTires());
            car[0].setModel("166");
            car[0].setBobyType("седан");
            car[0].setEngineCapacity(1800);
            car[3].setModel("146");
            car[3].setCost(8888.88);
            car[4].setBobyType("Coupe");
            car[4].setEngineType("Gasoline");
            car[4].setEngineCapacity(2000);
            foreach (Car c in car)
                c.carInfo();
            Console.WriteLine("\n\nМетод из \"другого\" файла\nМодель испрашиваемого авто:  " + car[4].WhichModel());
        }
    }
}
