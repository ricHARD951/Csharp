//Program 
// See https://aka.ms/new-console-template for more information

using praca_s_file;

string file_path = "..\\..\\..\\Resources\\f1_drivers_points.csv";
string save_file_path = "..\\..\\..\\driver_results.txt";

var driverStats = new DriverStats();
driverStats.LoadCsv(file_path);

Console.WriteLine(driverStats.MostScoredPoints());
Console.WriteLine(driverStats.MostPoles());
Console.WriteLine(driverStats.MostLapsLed());

driverStats.SaveTxt(save_file_path);

Console.WriteLine("Záznam sa vytvoril");

//F1Driver

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praca_s_file
{
    class F1Driver
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Team { get; set; }
        public int Age { get; set; }
        public int Points { get; set; }
        public int DNF { get; set; }
        public int Wins { get; set; }
        public int Podiums { get; set; }
        public int FastestLaps { get; set; }
        public int DriverOfTheDay { get; set; }
        public int MostOvertakes { get; set; }
        public int Poles { get; set; }
        public int LapsLed { get; set; }

        public F1Driver(string name, string nationality, string team, int age, int points, int dnf,
            int wins, int podiums, int fastestLaps, int driverOfTheDay, int mostOvertakes, int poles, int lapsLed)
        {
            Name = name;
            Nationality = nationality;
            Team = team;
            Age = age;
            Points = points;
            DNF = dnf;
            Wins = wins;
            Podiums = podiums;
            FastestLaps = fastestLaps;
            DriverOfTheDay = driverOfTheDay;
            MostOvertakes = mostOvertakes;
            Poles = poles;
            LapsLed = lapsLed;
        }
    }
}


// Driverstats
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praca_s_file
{
    class DriverStats
    {
        public List<F1Driver> Drivers { get; set; }

        public DriverStats()
        {
            Drivers = new List<F1Driver>();
        }

        public void LoadCsv(string path)
        {
            using (var reader = new StreamReader(path))
            {
                reader.ReadLine(); 

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var driver = new F1Driver(
                        values[0],
                        values[1],
                        values[2],
                        int.Parse(values[3]),
                        int.Parse(values[4]),
                        int.Parse(values[5]),
                        int.Parse(values[6]),
                        int.Parse(values[7]),
                        int.Parse(values[8]),
                        int.Parse(values[9]),
                        int.Parse(values[10]),
                        int.Parse(values[11]),
                        int.Parse(values[12])
                    );

                    Drivers.Add(driver);
                }
            }
        }

        public string MostScoredPoints()
        {
            var driver = Drivers.OrderByDescending(d => d.Points).First();
            return $"{driver.Name} MostScoredPoints  ({driver.Points})";
        }

        public string MostPoles()
        {
            var driver = Drivers.OrderByDescending(d => d.Poles).First();
            return $"{driver.Name} MostPoles ({driver.Poles})";
        }

        public string MostLapsLed()
        {
            var driver = Drivers.OrderByDescending(d => d.LapsLed).First();
            return $"{driver.Name} MostLapsLed ({driver.LapsLed})";
        }

        public void SaveTxt(string path)
        {
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(MostScoredPoints());
                writer.WriteLine(MostPoles());
                writer.WriteLine(MostLapsLed());
            }
        }
    }

}
