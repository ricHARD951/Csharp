using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class Car
    {
        public string vyrobca { get; set; }
        public string model { get; set; }

        public double cena { get; set; }
            
        public string prevodovka { get; set; }

        public string fuel { get; set; }

        public double hp { get; set; }


        public Car(string _vyrobca, string _model, double _cena, string _prevodovka, string _fuel, double _hp)
        {
            this.vyrobca = _vyrobca;
            this.model = _model;
            this.cena = _cena;
            this.prevodovka = _prevodovka;
            this.fuel = _fuel;
            this.hp = _hp;
        }

        public string PrintInfo()
        {
            string return_string = this.vyrobca + " " + this.model + " " + this.cena + " " + this.prevodovka + " " + this.fuel + " " + this.hp;
            return return_string;
        }
    }
}
