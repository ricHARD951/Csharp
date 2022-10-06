using System;

namespace Auto
{
    class Program
    {

        static void Main(string[] args)
        {
            Car amg = new Car("Mercedes-benz", "AMG GT", 999.9, "Automatic", "petrol", 585);
            Car mustang = new Car("Ford", "Mustang", 699.9, "Automatic", "gasoline", 480);
            Car fabka = new Car("Skoda", "Fabia", 29.9, "Manual", "gasoline", 150);
            Car passat = new Car("VW", "Passat", 79.9, "Automatic", "gasoline", 174);
            Car golf = new Car("VW", "Golf", 69.9, "Manual", "gasoline", 90);
            Car a4 = new Car("Audi", "A4", 299.9, "Automatic", "gasoline", 201);
            Car mko = new Car("BMW", "535i m sport", 699.9, "Automatic", "gasoline", 240);
            Car rolls = new Car("Rolls-royce", "Phantom", 12999.9, "Automatic", "petrol", 563);


            Console.WriteLine(amg.PrintInfo());

            Employee marek = new Employee("Marek", "Maly", 949755321, "mmaly@email.com", 12.70);
            Employee anna = new Employee("Anna", "Alka", 94555114, "annnnna@email.com", 12.50);
            Employee rene = new Employee("Rene", "Rendy", 90584314, "rrednyy@email.com", 32.50);

            

            Console.WriteLine(marek.PrintInfo());


            Pozicovna pozicovna = new Pozicovna("Závodská cesta 6 01001 Zilina", "8:00 - 16:00", 944555631);






            pozicovna.AddCar(amg);
            pozicovna.AddCar(mustang);
            pozicovna.AddCar(fabka);
            pozicovna.AddCar(passat);
            pozicovna.AddCar(golf);
            pozicovna.AddCar(a4);
            pozicovna.AddCar(mko);
            pozicovna.AddCar(rolls);

            pozicovna.AddEmplyee(rene);
            pozicovna.AddEmplyee(anna);
            pozicovna.AddEmplyee(marek);
        }
       
       

        }
    
}

