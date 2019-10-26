using System;
using System.Collections.Generic;
using System.Text;

namespace HWDay2
{
    public partial class Car
    {
        private static string brand = "Alfa Romeo";
        private static short nTires = 4;
        private string Model { get; set; }
        private string BodyType { get; set; }
        private string EngineType { get; set; }
        private int EngineCapacity { get; set; }
        private double Cost { get; set; }
        private bool SportCar { get; set; }
        private short nDoor { get; set; }
        private string transmissionType { get; set; }
        private string color { get; set; }
        static Car() { }
        public Car() { }
        public string getModel()
        {
            return Model;
        }
        public void setModel(string model)
        {
            Model = model;
        }
        public string getBbodyType()
        {
            return BodyType;
        }
        public void setBobyType(string bodyType)
        {
            BodyType = bodyType;
        }
        public string getEngineType()
        {
            return EngineType;
        }
        public void setEngineType(string engineType)
        {
            EngineType = engineType;
        }
        public int getEngineCapacity()
        {
            return EngineCapacity;
        }
        public void setEngineCapacity(int engineCapacity)
        {
            EngineCapacity = engineCapacity;
        }
        public double getCost()
        {
            return Cost;
        }
        public void setCost(double cost)
        {
            Cost = cost;
        }



        public Car(string bodyType, string engineType, int engineCapacity)
        {
            BodyType = bodyType;
            EngineType = engineType;
            EngineCapacity = engineCapacity;
        }
        public Car(string model, double cost, bool sportCar = false)
        {
            Model = model;
            Cost = cost;
            SportCar = sportCar;
        }


        public void choiceDisk(string D)
        {
            Console.Clear();
            if (int.TryParse(D, out int d) && d > 13 && d < 22)
            {
                Console.WriteLine("Диамерт колесного диска - " + d);
            }
            else
            {
                d = 13;
                Console.WriteLine("Некорректное значение..\n" +
                    "По умолчанию Диамерт колесного диска - " + d +
                    "\nВ следующий раз повезет..");
            }

        }
        public int MoreTires()
        {
            Console.WriteLine("Сколько запасных покрышек (0..8)");
            string moreTires = Console.ReadLine();
            int total = nTires;
            if(int.TryParse(moreTires, out int more) && more > -1 && more < 8)
            {
                total +=more;
            }
            else
            {
                Console.WriteLine("Некорректное значение..\n");
            }
            return total;
        }
        public void carInfo()
        {
            Console.WriteLine(
                "\n           Марка:  " + brand +
                "\n          Модель:  " + Model +
                "\n           Кузов:  " + BodyType +
                "\n   Тип двигателя:  " + EngineType +
                "\n Oбъем двигателя:  " + EngineCapacity +
                "\n            Цена:  " + Cost +
                "\nШины в комплекте:  " + nTires +
                "\n       SportCar?:  " + SportCar
                );

            Console.WriteLine("\n------------------------------");
        }
    }


}
