using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Písomka_pred_Vianocami
{
    public class Firm
    {
        public List<Employee> Employees { get; set; }

        public Firm()
        {
            Employees = new List<Employee>();
        }

        public void PrintEmployeesWithIncome(double income)
        {
            foreach (var employee in Employees)
            {
                if (employee.calculateSalaryNetto() >= income)
                {
                    Console.WriteLine(employee);
                    Console.WriteLine();
                }
            }
        }
    }
}
