using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ДЗ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("audi", 1000, 2015);

            PassengerCar car2 = new PassengerCar("skoda", 1500, 2005, 4);
            car2.AddToRepairBook("window", "2004");
            car2.AddToRepairBook("wheel", "2022");
            car2.AddToRepairBook("door", "2014");

          

            Truck truck1 = new Truck("Crutoy truck", 10000, 2020, 15000, "Karpov_Dmitry");
            truck1.AddCargo("Kvas", 13000);

            Truck truck2 = new Truck("Takoy sebe truck", 10, 2023, 3000, "Vasin_Vasiliy");

            List<Car> list = new List<Car>() { car1, car2, truck1, truck2 };
            Autopark autopark = new Autopark(list);
            Console.WriteLine(autopark.ToString());
            Console.ReadKey();
        }
    }
}
