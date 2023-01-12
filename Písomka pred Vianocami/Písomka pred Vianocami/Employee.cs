using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Písomka_pred_Vianocami
{
    public class Employee : Person
    {
        public double SalaryBrutto { get; set; }
        public Employee(string _firstName, string _lastName, int _age, double _height, double _salaryBrutto ) : base(_firstName, _lastName, _age, _height)
        {
            SalaryBrutto= _salaryBrutto;
        }

        public double calculateSalaryNetto()
        {
            return (SalaryBrutto/100) * 70.15;
        }

        public double calculateIncomeTax()
        {
            return (SalaryBrutto / 100) * 16.45;
        }

        public double calculateInsurance()
        {
            return (SalaryBrutto / 100) * 13.40;
        }

        public override string ToString()
        {
            return "Name: " + FirstName + "\nSurname: " + LastName + "\nAge: " + Age + "\nHeight: " + Height + "\nBrutto salary: " + SalaryBrutto
                + "\n Netto salary: " + calculateSalaryNetto() + "\nIncome Tax: " + calculateIncomeTax() + "\nInsurance: " + calculateInsurance();
        }


    }
}
