using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ДЗ3
{
    public class Car
    {
        protected string _brand;
        protected int _power;
        protected int _year;

        public string Brand { get => _brand; set => _brand = value; }
        public int Power { get => _power; set => _power = value; }
        public int Year { get => _year; set => _year = value; }
        
        public Car(string brandval, int powerval, int yearval)
        {
            this._brand = brandval;
            this._power = powerval;
            this._year = yearval;
        }

        public override string ToString()
        {
            return $"Brand:\t{_brand}\nPower:\t{_power}\nYear:\t{_year}";
        }
    }

    public class PassengerCar : Car
    {
        private int _NumOfPas { get; set; }
        private Dictionary<string, string> _RepairBook = new Dictionary<string, string>();
        public PassengerCar(string brandval, int powerval, int yearval,int NumOfPasval) : base(brandval, powerval, yearval)
        {
            if (NumOfPasval > 0) this._NumOfPas = NumOfPasval;          
        }

        public void AddToRepairBook(string key, string value)
        {
            _RepairBook.Add(key, value);
        }

        public string GetFromRepairBook(string key)
        {

            if (_RepairBook.ContainsKey(key))
            {
                return _RepairBook[key];
            }
            else
            {
                return "Данные не найдены в ремонтной книжке";
            }
        }

        public void RepairBookInfo()
        {
            foreach(string key in _RepairBook.Keys)
            {
                Console.WriteLine($"{key}\t{_RepairBook[key]}");
            }
        }

        public override string ToString()
        {
            return $"Brand:\t{_brand}\nPower:\t{_power}\nYear:\t{ _year}\nNumber Of Passangers:\t{_NumOfPas}";
        }


    }

    public class Truck : Car
    {
        private int _maxcapacity;
        private string _fi;
        private Dictionary<string, int> _currentcargo = new Dictionary<string, int>();
        public Truck(string brandval, int powerval, int yearval, int MaxCapacity, string FI) : base(brandval, powerval, yearval)
        {
            this._maxcapacity = MaxCapacity;
            this._fi = FI;
        }

        public void ChangeDriver(string fi_value) // Фамилия и имя вводятся через _ /// Пример: Ivanov_Ivan или Иванов_Иван
        {
            _fi = fi_value;
        }

        public void AddCargo(string name, int weight)
        {
            if (weight > _maxcapacity) Console.WriteLine("Вес груза превышает максимальную грузоподъемность");
            else
            {
                _currentcargo.Clear();
                _currentcargo.Add(name, weight);
            }
            
        }

        public void DeleteCargo()
        {
            _currentcargo.Clear();
        }

        public void CurretCargoInfo()
        {
            if (_currentcargo.Count() == 0) Console.WriteLine("Груз отсутствует");
            else
            {
                foreach (string key in _currentcargo.Keys)
                {
                    Console.WriteLine($"{key}\t{_currentcargo[key]}");
                }
            }
        }

        public override string ToString()
        {
            return $"Brand:\t{_brand}\nPower:\t{_power}\nYear:\t{ _year}\nMax Capacity:\t{_maxcapacity}\nLast name first name of the driver:\t{_fi}";
        }
    }

    public class Autopark
    {
        private List<Car> _autopark = new List<Car>();
        public Autopark(List<Car> Autopark)
        {
            _autopark = Autopark;
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < _autopark.Count(); ++i)
            {
                str += _autopark[i].ToString() + "\n\n\n";
            }
            return str;
        }
    }



}

