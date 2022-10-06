using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class Employee
    {
        public string meno { get; set; }

        public string priezvisko { get; set; }
        public double telCislo { get; set; }

        public string email { get; set; }

        public double mph { get; set; }

        public Employee(string _meno, string _priezvisko, double _telCislo, string _email,  double _mph)
        {
            this.meno = _meno;
            this.priezvisko = _priezvisko;
            this.telCislo = _telCislo;
            this.email = _email;
            this.mph = _mph;
        }



        public string PrintInfo()
        {
            string return_string = this.meno + " " + this.priezvisko + " " + this.telCislo + " " + this.email + " " + this.mph;
            return return_string;
        }





    }
}
