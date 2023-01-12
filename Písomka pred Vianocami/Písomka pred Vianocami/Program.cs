﻿using Písomka_pred_Vianocami;

Console.WriteLine("Person:");
Console.WriteLine();
Person p = new Person("Peter", "Cmorik", 36, 1.87);
Console.WriteLine(p);

Console.WriteLine("Employee:");
Console.WriteLine();
Employee e = new Employee("Emil", "Dakar", 36, 1.89, 1500);
Console.WriteLine(e);
Console.WriteLine("Firm:");
Console.WriteLine();

Firm firm = new();
firm.Employees.Add(e);
firm.Employees.Add(new Employee("Anna", "Maria", 21, 1.80, 1750));
firm.Employees.Add(new Employee("Fero", "Biely", 34, 2.00, 200));
firm.Employees.Add(new Employee("Michal", "Modry", 44, 2.01, 1200));
firm.Employees.Add(new Employee("Adrian", "Zeleny", 22, 1.85, 1000));
firm.Employees.Add(new Employee("Jakub", "Lajos", 51, 1.55, 900));
firm.Employees.Add(new Employee("Tomas", "Fik", 25, 1.91, 2100));
firm.Employees.Add(new Employee("Julia", "Mala", 27, 1.60, 1950));
firm.Employees.Add(new Employee("Zuzana", "Biela", 39, 1.55, 1650));
firm.Employees.Add(new Employee("Samuel", "Silny", 37, 1.65, 1300));
Console.WriteLine("1200+");
firm.PrintEmployeesWithIncome(1200);