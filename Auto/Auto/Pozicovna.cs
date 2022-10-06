using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class Pozicovna
    {
        public string adresa { get; set; }
        public string otvHodiny { get; set; }

        public double telCislo { get; set; }

        public Pozicovna(string _adresa, string _otvHodiny, double _telCislo)
        {
            this.adresa = _adresa;
            this.otvHodiny = _otvHodiny;
            this.telCislo = _telCislo;
        }

        public List<Car> cars;
        public void AddCar(Car cars)
        {
            this.cars.Add(cars);

        }
  

        public List<Employee> employees;
        public void AddEmplyee(Employee employees)
        {
            this.employees.Add(employees);

        }



    }
}
